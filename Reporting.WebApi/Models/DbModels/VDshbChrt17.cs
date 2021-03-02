using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDshbChrt17
    {
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public decimal? ProjectPriority { get; set; }
        public string VersionCode { get; set; }
        public string VersionName { get; set; }
        public string CriterionCode { get; set; }
        public string CriterionName { get; set; }
        public string CriterionFullName { get; set; }
        public decimal? CriterionValue { get; set; }
    }
}
