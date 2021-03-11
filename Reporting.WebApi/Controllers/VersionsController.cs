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

        /// <summary>
        /// Цели.
        /// </summary>
        /// <param name="versionId"></param>
        /// <returns></returns>
        [HttpGet("getGoals/{versionId}")]
        public async Task<IActionResult> GetGoals(Guid versionId)
        {
            var goals = await _fkpSystemContext.VStructureStructureLights
                .Where(s => s.VersionId == versionId && s.TypeIdCode == "Цели").ToListAsync();

            return new ObjectResult(goals);
        }

        /// <summary>
        /// Задачи.
        /// </summary>
        /// <param name="versionId"></param>
        /// <returns></returns>
        [HttpGet("getObjectives/{versionId}")]
        public async Task<IActionResult> GetObjectives(Guid versionId)
        {
            var objectives = await _fkpSystemContext.VStructureStructureLights
                .Where(s => s.VersionId == versionId && s.TypeIdCode == "Задачи").ToListAsync();

            return new ObjectResult(objectives);
        }

        [HttpGet("getGeneralInfo/{versionId}")]
        public async Task<IActionResult> GetGeneralInfo(Guid versionId)
        {
            var totalFinanceLimit = await _fkpSystemContext.VFinanceLimits.Where(f => f.VersionId == versionId)
                .SumAsync(f => f.NSum);

            var totalProjects = await _fkpSystemContext.VProjectProjects.CountAsync(p => p.VersionId == versionId);

            var totalWorks = await _fkpSystemContext.VDictionaryWorks.CountAsync(w => w.VersionId == versionId);

            var totalLaunches = await _fkpSystemContext.VSpacecraftSpacecrafts.CountAsync(s => s.VersionId == versionId);

            var totalCompletedLaunches = await _fkpSystemContext.VSpacecraftSpacecrafts
                .CountAsync(s => s.VersionId == versionId && s.StateName == "Запущен");

            return new ObjectResult(new
            {
                totalFinanceLimit,
                totalProjects,
                totalWorks,
                totalLaunches,
                totalCompletedLaunches
            });
        }
    }
}
