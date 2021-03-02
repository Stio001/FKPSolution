using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryPriorityCriterionKindSpec
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsAutoCalc { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public decimal? RankValue { get; set; }
        public bool? IsCalculated { get; set; }
    }
}
