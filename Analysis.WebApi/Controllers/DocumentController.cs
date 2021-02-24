using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Analysis.WebApi.Models;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using Microsoft.EntityFrameworkCore;

namespace Analysis.WebApi.Controllers
{
    [Route("analysis/[controller]/[action]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly AnalysisContext _analysisContext;

        public DocumentController(AnalysisContext analysisContext)
        {
            _analysisContext = analysisContext;
        }

        [HttpPost]
        public async Task<IActionResult> TryParseDoc(string nameDoc)
        {
            RichEditDocumentServer richDocSrv = new RichEditDocumentServer();

            bool docLoadOK = false;
            try
            {
                //var formCollection = await Request.ReadFormAsync();
                //var file = formCollection.Files.First();
                //docLoadOK = richDocSrv.LoadDocument(file.OpenReadStream());
                docLoadOK = richDocSrv.LoadDocument("Documents\\rasporyagenie.docx");
            }
            catch
            {
                return BadRequest("Не удалось загрузить документ.");
            }

            if (!docLoadOK)
            {
                return BadRequest("Не удалось загрузить документ.");
            }

            const string headerPrefix = "heading";
            var document = richDocSrv.Document;

            var docModel = new Doc()
            {
                Name = nameDoc,
                DocParts = new List<DocPart>()
            };
            var docParts = docModel.DocParts;

            DocPart lastHeaderStylePart = null;
            DocPart titleListItems = null;
            bool isListItem = false;
            foreach (var paragraph in document.Paragraphs)
            {
                var paragraphText = document.GetText(paragraph.Range);
                if (string.IsNullOrEmpty(paragraphText))
                    continue;

                // Заголовок - создаем узел диаграммы.
                var docPart = new DocPart
                {
                    Content = paragraphText
                };

                var headerStyle = paragraph.Style.Name.ToLowerInvariant();
                if (headerStyle.StartsWith(headerPrefix))
                {
                    var headerStyleSplit = paragraph.Style.Name.Split(' ');
                    if (headerStyleSplit.Length > 1 && int.TryParse(headerStyleSplit.LastOrDefault(), out int partLevel))
                    {
                        docPart.PartLevel = partLevel;
                    }
                    else
                    {
                        docPart.PartLevel = 0;
                    }

                    lastHeaderStylePart = docPart;
                    docParts.Add(docPart);
                }
                else
                // Не заголовок - добавляем параграф к предыдущему узлу.
                {
                    if (isListItem && titleListItems != null)
                    {
                        docPart.Parent = titleListItems;
                        docPart.PartLevel = titleListItems.PartLevel + 1;
                        docParts.Add(docPart);

                        if (paragraphText.EndsWith("."))
                        {
                            isListItem = false;
                            titleListItems = null;
                        }
                    }
                    else
                    {
                        if (lastHeaderStylePart != null)
                        {
                            docPart.Parent = lastHeaderStylePart;
                            docPart.PartLevel = lastHeaderStylePart.PartLevel + 1;
                            docParts.Add(docPart);

                            if (paragraphText.EndsWith(":"))
                            {
                                isListItem = true;
                                titleListItems = docPart;
                            }
                        }
                    }
                }
            }

            await _analysisContext.Docs.AddAsync(docModel);
            await _analysisContext.SaveChangesAsync();

            return Ok(docParts.Select(docPart => new
            {
                docPart.Id,
                docPart.PartLevel,
                docPart.Header,
                docPart.Content,
                docPart.ParentId,
                docPart.DocId
            }));
        }

        [HttpGet("{id}")]
        public IActionResult GetDocModel(Guid id)
        {
            var docParts = _analysisContext.DocParts.Where(docPart => docPart.DocId == id)
                .Select(docPart => new
                {
                    docPart.Id,
                    docPart.PartLevel,
                    docPart.Header,
                    docPart.Content,
                    docPart.ParentId,
                    docPart.DocId
                });
            return new ObjectResult(docParts);
        }

        [HttpGet]
        public async Task<IActionResult> GetDocumentsList()
        {
            return new ObjectResult(await _analysisContext.Docs.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoc(Guid id)
        {
            try
            {
                var doc = await _analysisContext.Docs.FirstOrDefaultAsync(d => d.Id == id);
                _analysisContext.Docs.Remove(doc);

                await _analysisContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
