using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VPriorityCriterionScale
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public decimal CriterionValue { get; set; }
        public string ScaleName { get; set; }
        public decimal? ParamValueFrom { get; set; }
        public decimal? ParamValueTo { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
    }
}
