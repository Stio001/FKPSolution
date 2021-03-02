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
    public class SpacecraftsController : ControllerBase
    {
        private readonly FKPSystemContext _fkpSystemContext;

        public SpacecraftsController(FKPSystemContext fkpSystemContext)
        {
            _fkpSystemContext = fkpSystemContext;
        }

        [Route("spacecraftschedule/{versionId}"), HttpGet]
        public async Task<IActionResult> SpacecraftSchedule(Guid versionId)
        {
            var spacecraftSchedule = await _fkpSystemContext.VSpacecraftSpacecraftSchedules
                .Where(s => s.VersionId == versionId
                            && !string.IsNullOrEmpty(s.SpacecraftDescription)
                            && s.StateCode == "Запланирован").ToListAsync();

            return new ObjectResult(spacecraftSchedule);
        }
    }
}
