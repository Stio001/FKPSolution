using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkCompareVersion
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string ShortName { get; set; }
        public int? WorkType { get; set; }
        public string WorkTypeCode { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? WorkCodeId { get; set; }
        public string WorkCodeCode { get; set; }
        public string WorkCodeIdCode { get; set; }
        public decimal? Rank { get; set; }
        public string RegNum { get; set; }
        public string ProgNum { get; set; }
        public Guid? SectionId { get; set; }
        public string SectionCode { get; set; }
        public Guid? StageId { get; set; }
        public string StageCode { get; set; }
        public string StageIdCode { get; set; }
        public bool? UseInDoc { get; set; }
        public bool? IsDone { get; set; }
        public Guid? KindId { get; set; }
        public string KindIdCode { get; set; }
        public string Level1 { get; set; }
        public string Level2 { get; set; }
        public string Level3 { get; set; }
        public string Level4 { get; set; }
        public string SectionIdCode { get; set; }
        public string InfoCode { get; set; }
        public Guid VersionId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string ProjectIdCode { get; set; }
        public int? FinDirection { get; set; }
        public string FinDirectionCode { get; set; }
        public decimal? StagePercent { get; set; }
        public decimal? StageValue { get; set; }
        public int? DiffereceCount1 { get; set; }
        public int? DiffereceCount2 { get; set; }
        public int? DiffereceCount3 { get; set; }
        public int? DiffereceCount4 { get; set; }
        public string PrintName { get; set; }
        public string Version1Code { get; set; }
        public string Version2Code { get; set; }
    }
}
