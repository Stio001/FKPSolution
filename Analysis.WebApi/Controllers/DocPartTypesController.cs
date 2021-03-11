using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Analysis.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Analysis.WebApi.Models.DbModels;
using Analysis.WebApi.Models.Dto;

namespace Analysis.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocPartTypesController : ControllerBase
    {
        private readonly AnalysisContext _context;

        public DocPartTypesController(AnalysisContext context)
        {
            _context = context;
        }

        // GET: api/DocPartTypes/5
        [HttpGet("{docPartTypeId}")]
        public async Task<ActionResult<DocPartType>> GetDocPartType(Guid docPartTypeId)
        {
            var docPartType = await _context.DocPartTypes.FindAsync(docPartTypeId);

            if (docPartType == null)
            {
                return NotFound();
            }

            return docPartType;
        }

        [HttpGet("{docTypeId}")]
        public async Task<IActionResult> GetDocPartTypes(Guid docTypeId)
        {
            var docPartTypes = await _context.DocPartTypes.Where(d => d.DocTypeId == docTypeId).ToListAsync();

            if (docPartTypes == null)
            {
                return NotFound();
            }

            return new ObjectResult(docPartTypes);
        }

        // PUT: api/DocPartTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutDocPartType(DocPartTypeForUpdateDto model)
        {
            var docPartType = await _context.DocPartTypes.FindAsync(model.Id);

            if (docPartType == null)
                return NotFound();

            docPartType.Name = model.Name;
            docPartType.KeyWords = model.KeyWords;

            _context.Update(docPartType);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // POST: api/DocPartTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostDocPartType(DocPartTypeToCreateDto model)
        {
            var docPartType = new DocPartType()
            {
                Name = model.Name,
                KeyWords = model.KeyWords,
                DocTypeId = model.DocTypeId
            };

            await _context.DocPartTypes.AddAsync(docPartType);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/DocPartTypes/5
        [HttpDelete("{docPartTypeId}")]
        public async Task<IActionResult> DeleteDocPartType(Guid docPartTypeId)
        {
            var docPartType = await _context.DocPartTypes.FindAsync(docPartTypeId);
            if (docPartType == null)
            {
                return NotFound();
            }

            _context.DocPartTypes.Remove(docPartType);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
