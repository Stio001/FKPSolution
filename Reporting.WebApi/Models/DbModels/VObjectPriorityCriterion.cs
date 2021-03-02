using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VObjectPriorityCriterion
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid CriterionId { get; set; }
        public Guid VersionId { get; set; }
        public decimal? ParamValue { get; set; }
        public decimal? CriterionValue { get; set; }
        public decimal? Priority { get; set; }
        public DateTime? CalcDate { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string CriterionIdCode { get; set; }
        public string CriterionCode { get; set; }
        public string CriterionDescription { get; set; }
        public bool? IsAutoCalc { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public decimal? RankValue { get; set; }
        public string Protocol { get; set; }
        public decimal? ValueN1 { get; set; }
        public decimal? ValueN2 { get; set; }
        public decimal? ValueN3 { get; set; }
    }
}
