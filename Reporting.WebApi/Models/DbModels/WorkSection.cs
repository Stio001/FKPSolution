using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class WorkSection
    {
        public WorkSection()
        {
            DictionaryWorks = new HashSet<DictionaryWork>();
            FinanceLimitSpecs = new HashSet<FinanceLimitSpec>();
            InverseParent = new HashSet<WorkSection>();
            WorkWorks = new HashSet<WorkWork>();
        }

        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        public virtual WorkSection Parent { get; set; }
        public virtual ICollection<DictionaryWork> DictionaryWorks { get; set; }
        public virtual ICollection<FinanceLimitSpec> FinanceLimitSpecs { get; set; }
        public virtual ICollection<WorkSection> InverseParent { get; set; }
        public virtual ICollection<WorkWork> WorkWorks { get; set; }
    }
}
