using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryPriorityCriterion
    {
        public DictionaryPriorityCriterion()
        {
            PriorityCriterionObjects = new HashSet<PriorityCriterionObject>();
            PriorityCriterionScales = new HashSet<PriorityCriterionScale>();
        }

        public Guid Rid { get; set; }
        public Guid CategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool? IsAutoCalc { get; set; }
        public bool? IsCalculated { get; set; }

        public virtual DictionaryDictionary Category { get; set; }
        public virtual ICollection<PriorityCriterionObject> PriorityCriterionObjects { get; set; }
        public virtual ICollection<PriorityCriterionScale> PriorityCriterionScales { get; set; }
    }
}
