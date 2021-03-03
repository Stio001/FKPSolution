using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Analysis.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Novacode;

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
            DocX document;
            try
            {
                //var formCollection = await Request.ReadFormAsync();
                //var file = formCollection.Files.First();
                //DocX document = DocX.Load(file.OpenReadStream());
                document = DocX.Load("Documents\\rasporyagenie.docx");
            }
            catch (Exception e)
            {
                return BadRequest("Не удалось загрузить документ");
            }
            

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
                var paragraphText = paragraph.Text;
                if (string.IsNullOrEmpty(paragraphText))
                    continue;

                // Заголовок - создаем узел диаграммы.
                var docPart = new DocPart
                {
                    Content = paragraphText
                };

                if (int.TryParse(paragraph.StyleName, out int partLevel))
                {
                        docPart.PartLevel = partLevel;
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
