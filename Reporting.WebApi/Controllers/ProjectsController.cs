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
    public class ProjectsController : ControllerBase
    {
        private readonly FKPSystemContext _fkpSystemContext;

        public ProjectsController(FKPSystemContext fKPSystemContext)
        {
            _fkpSystemContext = fKPSystemContext;
        }

        /// <summary>
        /// Проекты.
        /// </summary>
        /// <param name="versionId"></param>
        /// <returns></returns>
        [HttpGet("{versionId}")]
        public async Task<IActionResult> GetProjects(Guid versionId)
        {
            var projects = await _fkpSystemContext.VProjectProjects
                .Where(p => p.VersionId == versionId).Select(p => new
                {
                    name = p.Name,
                    code = p.Code,
                    systemName = p.SystemName,
                    type = p.TypeIdName,
                    priority = p.Priority,
                    cost = p.FinSum,
                    mastered = p.FinSum1,
                    remains = p.FinSum2
                }).ToListAsync();

            return new ObjectResult(projects);
        }

        /// <summary>
        /// Общее количество проектов для версии.
        /// </summary>
        /// <param name="versionId"></param>
        /// <returns></returns>
        [HttpGet("getTotalProjects/{versionId}")]
        public async Task<IActionResult> GetTotalProjects(Guid versionId)
        {
            var totalProjects = await _fkpSystemContext.VProjectProjects.CountAsync(p => p.VersionId == versionId);

            return new ObjectResult(totalProjects);
        }
    }
}
