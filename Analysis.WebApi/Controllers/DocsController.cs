using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Analysis.WebApi.Models;
using Analysis.WebApi.Models.DbModels;

namespace Analysis.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DocsController : ControllerBase
    {
        private readonly AnalysisContext _analysisContext;

        public DocsController(AnalysisContext analysisContext)
        {
            _analysisContext = analysisContext;
        }

        [HttpPost]
        public async Task<IActionResult> UploadDoc(UploadDocViewModel model)
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

                    var doc = new Doc()
                    {
                        Name = model.Name,
                        Description = model.Description,
                        TypeId = model.TypeId,
                        FilePath = dbPath,
                        FileName = fileName
                    };

                    await _analysisContext.Docs.AddAsync(doc);
                    await _analysisContext.SaveChangesAsync();

                    return Ok();
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
