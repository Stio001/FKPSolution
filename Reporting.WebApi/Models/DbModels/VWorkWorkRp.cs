using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VWorkWorkRp
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string ShortName { get; set; }
        public Guid? WorkCodeId { get; set; }
        public Guid? StageId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid VersionId { get; set; }
        public Guid? ParentId { get; set; }
        public int? ColorCondition { get; set; }
        public Guid EntryId { get; set; }
        public string StageIdCode { get; set; }
        public string StageIdName { get; set; }
        public string WorkCodeIdCode { get; set; }
        public string WorkCodeIdName { get; set; }
        public string Expr1 { get; set; }
        public string Expr2 { get; set; }
        public string VersionIdCode { get; set; }
        public decimal? Rank { get; set; }
        public string RegNum { get; set; }
        public string ProgNum { get; set; }
        public Guid? SectionId { get; set; }
        public string SectionIdCode { get; set; }
        public string SectionCode { get; set; }
        public Guid? DictionaryWorkId { get; set; }
        public string DictionaryWorkIdCode { get; set; }
        public string ProjectIdCode { get; set; }
        public int? OrderNum { get; set; }
    }
}
