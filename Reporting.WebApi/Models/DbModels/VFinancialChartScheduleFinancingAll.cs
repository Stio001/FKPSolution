using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VFinancialChartScheduleFinancingAll
    {
        public int? DateTo { get; set; }
        public decimal? SumValue { get; set; }
        public Guid VersionId { get; set; }
    }
}
