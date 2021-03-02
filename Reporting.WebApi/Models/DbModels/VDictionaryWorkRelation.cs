using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkRelation
    {
        public Guid DrRid { get; set; }
        public Guid DwinRid { get; set; }
        public Guid DwoutRid { get; set; }
        public string DwinCode { get; set; }
        public int? DwinDateFrom { get; set; }
        public int? DwinDateTo { get; set; }
        public string DwoutCode { get; set; }
        public int? DwoutDateFrom { get; set; }
        public int? DwoutDateTo { get; set; }
        public Guid VersionId { get; set; }
        public Guid? InParentId { get; set; }
        public Guid? OutParentId { get; set; }
    }
}
