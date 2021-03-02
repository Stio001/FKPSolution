using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reporting.WebApi.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Reporting.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VersionsController : ControllerBase
    {
        private readonly FKPSystemContext _fkpSystemContext;

        public VersionsController(FKPSystemContext fkpSystemContext)
        {
            _fkpSystemContext = fkpSystemContext;
        }

        /// <summary>
        /// Возвращает все версии.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var versions = await _fkpSystemContext.VersionVersions
                .Where(v =>
                    v.ParentId == null && v.IsRemoved != true)
                .Select(v => new
                {
                    v.Rid,
                    v.Code,
                    v.Name,
                    v.Description
                }).ToListAsync();

            return new ObjectResult(versions);
        }

        /// <summary>
        /// Возвращает одну версию с заданным id.
        /// </summary>
        /// <param name="id">Идентификатор версии</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var version = await _fkpSystemContext.VersionVersions
                .Where(v => v.Rid == id).FirstOrDefaultAsync();

            return new ObjectResult(version);
        }
    }
}
