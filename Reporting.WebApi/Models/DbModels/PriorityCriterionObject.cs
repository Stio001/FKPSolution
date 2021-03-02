using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class PriorityCriterionObject
    {
        public PriorityCriterionObject()
        {
            PriorityCriterionValues = new HashSet<PriorityCriterionValue>();
        }

        public Guid Rid { get; set; }
        public Guid ObjectId { get; set; }
        public Guid CriterionId { get; set; }
        public Guid VersionId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public decimal? ParamValue { get; set; }
        public decimal? CriterionValue { get; set; }
        public DateTime? CalcDate { get; set; }
        public decimal? Priority { get; set; }
        public string Protocol { get; set; }
        public decimal? ValueN1 { get; set; }
        public decimal? ValueN2 { get; set; }
        public decimal? ValueN3 { get; set; }

        public virtual DictionaryPriorityCriterion Criterion { get; set; }
        public virtual ProjectProject Object { get; set; }
        public virtual VersionVersion Version { get; set; }
        public virtual ICollection<PriorityCriterionValue> PriorityCriterionValues { get; set; }
    }
}
