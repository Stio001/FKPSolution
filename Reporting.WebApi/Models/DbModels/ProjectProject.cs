using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ProjectProject
    {
        public ProjectProject()
        {
            DictionaryWorks = new HashSet<DictionaryWork>();
            EconomicEffectProjects = new HashSet<EconomicEffectProject>();
            PriorityCriterionObjects = new HashSet<PriorityCriterionObject>();
            ProjectPlanFinDistributions = new HashSet<ProjectPlanFinDistribution>();
            ProjectUsers = new HashSet<ProjectUser>();
            TargetIndicatorProjects = new HashSet<TargetIndicatorProject>();
            WorkWorks = new HashSet<WorkWork>();
        }

        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? Priority { get; set; }
        public int? TypeId { get; set; }
        public Guid? VersionId { get; set; }
        public decimal? BaseRank { get; set; }
        public int? Priority2 { get; set; }
        public decimal? Priority3 { get; set; }
        public decimal? AllowableSum { get; set; }
        public decimal? LaborCost { get; set; }

        public virtual VersionVersion Version { get; set; }
        public virtual ICollection<DictionaryWork> DictionaryWorks { get; set; }
        public virtual ICollection<EconomicEffectProject> EconomicEffectProjects { get; set; }
        public virtual ICollection<PriorityCriterionObject> PriorityCriterionObjects { get; set; }
        public virtual ICollection<ProjectPlanFinDistribution> ProjectPlanFinDistributions { get; set; }
        public virtual ICollection<ProjectUser> ProjectUsers { get; set; }
        public virtual ICollection<TargetIndicatorProject> TargetIndicatorProjects { get; set; }
        public virtual ICollection<WorkWork> WorkWorks { get; set; }
    }
}
