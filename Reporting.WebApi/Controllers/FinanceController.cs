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
    public class FinanceController : ControllerBase
    {
        private readonly FKPSystemContext _fkpSystemContext;

        public FinanceController(FKPSystemContext fkpSystemContext)
        {
            _fkpSystemContext = fkpSystemContext;
        }

        /// <summary>
        /// Объем финансирования мероприятий Федеральной космической программы России в области в области приклыдных
        /// научных исследований и экспериментальных разработок, выполняемых по договорам на проведение НИОКиТР.
        /// </summary>
        /// <param name="versionId">Id версии, для которой возвращаются данные.</param>
        /// <returns></returns>
        [HttpGet("getfinanceworkplaces/{versionId}")]
        public async Task<IActionResult> GetFinanceWorkPlaces(Guid versionId)
        {
            var financeWorkPlaces = await _fkpSystemContext.VWorkFinanceWorkPlaces
                .Where(f => f.VersionId == versionId).ToListAsync();

            return new ObjectResult(financeWorkPlaces);
        }

        /// <summary>
        /// Финансовые лимиты по годам.
        /// </summary>
        /// <param name="versionId"></param>
        /// <returns></returns>
        [HttpGet("getFinanceLimitsByYear/{versionId}")]
        public async Task<IActionResult> GetFinanceLimitsByYear(Guid versionId)
        {
            var financeLimits = await _fkpSystemContext.VFinanceLimits
                .Where(f => f.VersionId == versionId).Select(f => new
                {
                    year = f.NYear,
                    sum = f.NSum
                }).ToListAsync();

            return new ObjectResult(financeLimits);
        }

        /// <summary>
        /// Общее финансирование.
        /// </summary>
        /// <param name="versionId"></param>
        /// <returns></returns>
        [HttpGet("getTotalFinanceLimit/{versionId}")]
        public async Task<IActionResult> GetTotalFinanceLimit(Guid versionId)
        {
            var totalFinanceLimit = await _fkpSystemContext.VFinanceLimits.Where(f => f.VersionId == versionId)
                .SumAsync(f => f.NSum);

            return new ObjectResult(totalFinanceLimit);
        }
    }
}
