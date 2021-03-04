using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Analysis.WebApi.Models;
using Analysis.WebApi.Models.DbModels;
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
        public async Task<IActionResult> TryParseDoc2(string nameDoc)
        {
            DocX document;
            try
            {
                //var formCollection = await Request.ReadFormAsync();
                //var file = formCollection.Files.First();
                //DocX document = DocX.Load(file.OpenReadStream());
                document = DocX.Load("Documents\\rasporyagenie.docx");
            }
            catch 
            {
                return BadRequest("Не удалось загрузить документ");
            }

            var docType = await _analysisContext.DocTypes.FirstOrDefaultAsync();

            var docModel = new Doc()
            {
                Name = nameDoc,
                Type = docType,
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

                var docPart = new DocPart
                {
                    Content = paragraphText
                };

                if (int.TryParse(paragraph.StyleName, out int partLevel))
                {
                    var docParent = docParts.LastOrDefault(d => d.PartLevel == partLevel - 1);

                    if (docParent != null)
                        docPart.Parent = docParent;

                    docPart.PartLevel = partLevel;
                    lastHeaderStylePart = docPart;
                    docParts.Add(docPart);
                }
                else
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
                docPart.Content,
                docPart.ParentId,
                docPart.DocId
            }));
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> TryParseDoc()
        {
            try
            {
                var formCollection = await Request.ReadFormAsync();
                var file = formCollection.Files.First();
                var folderName = Path.Combine("Resources", "Documents");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    await using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    var docType = _analysisContext.DocTypes.FirstOrDefault();

                    var doc = new Doc()
                    {
                        Name = "Госполитика",
                        Description = "Описание",
                        TypeId = docType.Id,
                        FilePath = dbPath,
                        FileName = fileName
                    };

                    await _analysisContext.Docs.AddAsync(doc);
                    await _analysisContext.SaveChangesAsync();

                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetDocModel(Guid id)
        {
            var docParts = _analysisContext.DocParts.Where(docPart => docPart.DocId == id)
                .Select(docPart => new
                {
                    docPart.Id,
                    docPart.PartLevel,
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
