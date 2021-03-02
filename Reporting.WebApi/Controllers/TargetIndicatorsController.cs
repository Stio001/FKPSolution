using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Reporting.WebApi.Models.DbModels;

namespace Reporting.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TargetIndicatorsController : ControllerBase
    {
        private readonly FKPSystemContext _fkpSystemContext;

        public TargetIndicatorsController(FKPSystemContext fkpSystemContext)
        {
            _fkpSystemContext = fkpSystemContext;
        }

        [HttpGet("{versionId}")]
        public async Task<IActionResult> Get(Guid versionId)
        {
            var targetIndicators = await _fkpSystemContext.VTargetIndicatorTargetIndicators
                .Where(t => t.VersionId == versionId).ToListAsync();

            return new ObjectResult(targetIndicators);
        }
    }
}
