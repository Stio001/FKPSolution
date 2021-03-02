using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class AgentPerson
    {
        public AgentPerson()
        {
            MmWorkGroupPeople = new HashSet<MmWorkGroupPerson>();
            MmWorkPeople = new HashSet<MmWorkPerson>();
            MmWorkPersonContributions = new HashSet<MmWorkPersonContribution>();
            MmWorkPersonParams = new HashSet<MmWorkPersonParam>();
            PriorityCriterionRanks = new HashSet<PriorityCriterionRank>();
            RiskEventValues = new HashSet<RiskEventValue>();
            StructureParams = new HashSet<StructureParam>();
            SystemIssues = new HashSet<SystemIssue>();
            UserUsers = new HashSet<UserUser>();
        }

        public Guid Rid { get; set; }
        public string TabNum { get; set; }
        public string Note { get; set; }
        public Guid CatalogId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid AgentId { get; set; }
        public Guid PostId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid? CategoryId { get; set; }
        public decimal? ProffKoef { get; set; }
        public decimal? WorkExp { get; set; }
        public string AcademicDegree { get; set; }
        public string AcademicTitle { get; set; }
        public string Education { get; set; }
        public string AddEducation { get; set; }
        public short? RatingEducation { get; set; }
        public short? RatingAddEducation { get; set; }
        public short? RatingAcademicDegree { get; set; }
        public short? RatingPost { get; set; }
        public short? RatingCurrentWork1 { get; set; }
        public short? RatingCurrentWork2 { get; set; }
        public short? RatingCurrentWork3 { get; set; }
        public short? RatingCurrentWork4 { get; set; }
        public short? RatingCurrentWork5 { get; set; }

        public virtual AgentAgent Agent { get; set; }
        public virtual CatalogCatalog Catalog { get; set; }
        public virtual DictionaryDictionary Category { get; set; }
        public virtual DepartmentDepartment Department { get; set; }
        public virtual PostPost Post { get; set; }
        public virtual ICollection<MmWorkGroupPerson> MmWorkGroupPeople { get; set; }
        public virtual ICollection<MmWorkPerson> MmWorkPeople { get; set; }
        public virtual ICollection<MmWorkPersonContribution> MmWorkPersonContributions { get; set; }
        public virtual ICollection<MmWorkPersonParam> MmWorkPersonParams { get; set; }
        public virtual ICollection<PriorityCriterionRank> PriorityCriterionRanks { get; set; }
        public virtual ICollection<RiskEventValue> RiskEventValues { get; set; }
        public virtual ICollection<StructureParam> StructureParams { get; set; }
        public virtual ICollection<SystemIssue> SystemIssues { get; set; }
        public virtual ICollection<UserUser> UserUsers { get; set; }
    }
}
