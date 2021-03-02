using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VStageStage
    {
        public Guid Rid { get; set; }
        public Guid DictionaryWorkId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid VersionId { get; set; }
        public string VersionIdCode { get; set; }
        public Guid CatalogId { get; set; }
        public string ProjectIdCode { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int StageOrder { get; set; }
        public int WorkType { get; set; }
        public string WorkTypeCode { get; set; }
        public Guid? Gostid { get; set; }
        public string GostidCode { get; set; }
        public Guid? StageTypeId { get; set; }
        public string StageTypeIdCode { get; set; }
        public string StageTypeIdName { get; set; }
        public decimal? Priority { get; set; }
        public Guid? KindId { get; set; }
        public string KindIdCode { get; set; }
        public Guid? WorkCategoryId { get; set; }
        public string WorkCategoryIdCode { get; set; }
        public decimal? StagePercent { get; set; }
        public decimal? StageValue { get; set; }
        public string Note { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
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
        public DateTime? LastDateRiskCalculate { get; set; }
        public Guid? WorkCodeId { get; set; }
        public string WorkCodeCode { get; set; }
        public string WorkCodeIdCode { get; set; }
    }
}
