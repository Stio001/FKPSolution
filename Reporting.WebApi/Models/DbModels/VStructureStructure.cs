using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VStructureStructure
    {
        public Guid? Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? ElementId { get; set; }
        public short? ElementType { get; set; }
        public Guid? VersionId { get; set; }
        public decimal? Priority { get; set; }
        public string TypeIdCode { get; set; }
        public string UserGroupList { get; set; }
        public string CipCode { get; set; }
        public string DirectionCode { get; set; }
        public int? WorkType { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string WorkTypeCode { get; set; }
        public string WorkCodeIdCode { get; set; }
        public int? MainType { get; set; }
        public decimal? R12 { get; set; }
        public decimal? R13 { get; set; }
        public decimal? R21 { get; set; }
        public decimal? R23 { get; set; }
        public decimal? R31 { get; set; }
        public decimal? R32 { get; set; }
        public decimal? RiskValueR { get; set; }
        public decimal? RiskValueR1 { get; set; }
        public decimal? RiskValueR2 { get; set; }
        public decimal? RiskValueR3 { get; set; }
        public int? StageOrder { get; set; }
        public DateTime? LastDateRiskCalculate { get; set; }
        public string SectionIdCode { get; set; }
        public int? SpacePolicyObjectiveNum { get; set; }
    }
}
