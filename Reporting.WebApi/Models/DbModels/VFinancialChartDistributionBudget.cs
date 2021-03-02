using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VFinancialChartDistributionBudget
    {
        public string ProjectIdCode { get; set; }
        public int? ProjectId { get; set; }
        public decimal? SumValue { get; set; }
        public Guid VersionId { get; set; }
        public int? WorkDirectionCode { get; set; }
    }
}
