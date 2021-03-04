using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Analysis.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Analysis.WebApi.Models.DbModels;

namespace Analysis.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DocTypesController : ControllerBase
    {
        private readonly AnalysisContext _context;

        public DocTypesController(AnalysisContext context)
        {
            _context = context;
        }

        // GET: api/DocTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocType>>> GetDocTypes()
        {
            return await _context.DocTypes.ToListAsync();
        }

        // GET: api/DocTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DocType>> GetDocType(Guid id)
        {
            var docType = await _context.DocTypes.FindAsync(id);

            if (docType == null)
            {
                return NotFound();
            }

            return docType;
        }

        // PUT: api/DocTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutDocType(DocTypeForUpdateDto model)
        {
            var docType = await _context.DocTypes.FindAsync(model.Id);

            if (docType == null)
            {
                return NotFound();
            }

            docType.Name = model.Name;
            docType.Description = model.Description;

            _context.Update(docType);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // POST: api/DocTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DocType>> PostDocType(DocTypeToCreateDto model)
        {
            var docType = new DocType()
            {
                Name = model.Name,
                Description = model.Description
            };

            await _context.DocTypes.AddAsync(docType);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/DocTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDocType(Guid id)
        {
            var docType = await _context.DocTypes.FindAsync(id);
            if (docType == null)
            {
                return NotFound();
            }

            _context.DocTypes.Remove(docType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DocTypeExists(Guid id)
        {
            return _context.DocTypes.Any(e => e.Id == id);
        }
    }
}
