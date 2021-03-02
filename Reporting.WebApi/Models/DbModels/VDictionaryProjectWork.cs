using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryProjectWork
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid VersionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? KindId { get; set; }
        public string KindIdCode { get; set; }
        public int? WorkType { get; set; }
        public string WorkTypeCode { get; set; }
        public string RegNum { get; set; }
        public string ProgNum { get; set; }
        public string ShortName { get; set; }
        public Guid? WorkCodeId { get; set; }
        public string WorkCodeIdCode { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? Rank { get; set; }
        public decimal? BaseRank { get; set; }
        public decimal? Priority { get; set; }
        public bool? UseInDoc { get; set; }
    }
}
