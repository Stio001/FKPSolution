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

        /// <summary>
        /// Перечень космических аппаратов научного и социально-экономического назначения.
        /// </summary>
        /// <param name="versionId">Id версии, для которой возвращаются данные.</param>
        /// <returns></returns>
        [HttpGet("spacecraftschedule/{versionId}")]
        public async Task<IActionResult> SpacecraftSchedule(Guid versionId)
        {
            var spacecraftSchedule = await _fkpSystemContext.VSpacecraftSpacecraftSchedules
                .Where(s => s.VersionId == versionId
                            && !string.IsNullOrEmpty(s.SpacecraftDescription)
                            && s.StateCode == "Запланирован").ToListAsync();

            return new ObjectResult(spacecraftSchedule);
        }

        /// <summary>
        /// Общее количество запусков.
        /// </summary>
        /// <param name="versionId"></param>
        /// <returns></returns>
        [HttpGet("getTotalLaunches/{versionId}")]
        public async Task<IActionResult> GetTotalLaunches(Guid versionId)
        {
            var totalLaunches = await _fkpSystemContext.VSpacecraftSpacecrafts.CountAsync(s => s.VersionId == versionId);

            return new ObjectResult(totalLaunches);
        }

        /// <summary>
        /// Количество выполненных запусков.
        /// </summary>
        /// <param name="versionId"></param>
        /// <returns></returns>
        [HttpGet("getTotalCompletedLaunches/{versionId}")]
        public async Task<IActionResult> GetTotalCompletedLaunches(Guid versionId)
        {
            var completedLaunches = await _fkpSystemContext.VSpacecraftSpacecrafts
                .CountAsync(s => s.VersionId == versionId && s.StateName == "Запущен");

            return new ObjectResult(completedLaunches);
        }
    }
}
