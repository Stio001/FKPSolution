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
    public class WorkEventsController : ControllerBase
    {
        private readonly FKPSystemContext _fkpSystemContext;

        public WorkEventsController(FKPSystemContext fkpSystemContext)
        {
            _fkpSystemContext = fkpSystemContext;
        }

        /// <summary>
        /// Перечень мероприятий Федеральной космической программы России в области прикладных научных
        /// исследований и экспериментальных разработок, выполняемых по договором на проведение НИОКиТР.
        /// </summary>
        /// <param name="versionId">Id версии, для которой возвращаются данные.</param>
        /// <returns></returns>
        [HttpGet("getworks/{versionId}")]
        public async Task<IActionResult> GetWorks(Guid versionId)
        {
            var works = await _fkpSystemContext.VDictionaryWorks
                .Where(w => w.VersionId == versionId 
                            && w.SectionIdCode != null 
                            && w.Level1 != null 
                            && w.Level2 != null).ToListAsync();

            return new ObjectResult(works);
        }


        /// <summary>
        /// Результаты по мероприятию.
        /// </summary>
        /// <param name="versionId">Id версии, для которой возвращаются данные.</param>
        /// <param name="workId">Id мероприятия, для которой возвращаются данные.</param>
        /// <returns></returns>
        [HttpGet("getworkresults/{versionId}/{workId}")]
        public async Task<IActionResult> GetWorkResults(Guid versionId, Guid workId)
        {
            var workResults = await _fkpSystemContext.VDictionaryWorkEventResults
                .Where(r => r.ParentId == workId && r.VersionId == versionId).ToListAsync();

            return new ObjectResult(workResults);
        }

        [HttpGet("getTotalWorks/{versionId}")]
        public async Task<IActionResult> GetTotalWorks(Guid versionId)
        {
            var totalWorks = await _fkpSystemContext.VDictionaryWorks.CountAsync(w => w.VersionId == versionId);

            return new ObjectResult(totalWorks);
        }
    }
}
