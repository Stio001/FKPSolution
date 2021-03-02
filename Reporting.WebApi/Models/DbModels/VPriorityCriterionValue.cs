using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VPriorityCriterionValue
    {
        public Guid Rid { get; set; }
        public Guid CriterionId { get; set; }
        public decimal? ParamValue { get; set; }
        public decimal? CriterionValue { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
