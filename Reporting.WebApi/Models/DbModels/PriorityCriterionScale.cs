using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class PriorityCriterionScale
    {
        public Guid Rid { get; set; }
        public Guid CriterionId { get; set; }
        public decimal CriterionValue { get; set; }
        public string ScaleName { get; set; }
        public decimal? ParamValueFrom { get; set; }
        public decimal? ParamValueTo { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        public virtual DictionaryPriorityCriterion Criterion { get; set; }
    }
}
