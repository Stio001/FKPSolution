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

        [Route("financeworkplaces/{versionId}"), HttpGet]
        public async Task<IActionResult> FinanceWorkPlaces(Guid versionId)
        {
            var financeWorkPlaces = await _fkpSystemContext.VWorkFinanceWorkPlaces
                .Where(f => f.VersionId == versionId).ToListAsync();

            return new ObjectResult(financeWorkPlaces);
        }
    }
}
