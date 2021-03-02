using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkEventFinPivot
    {
        public Guid WorkRid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid VersionId { get; set; }
        public Guid? EventRid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? WorkType { get; set; }
        public decimal? StagePercent { get; set; }
        public decimal? StageValue { get; set; }
        public int? NYear { get; set; }
        public decimal? Value { get; set; }
        public decimal? EventPercent { get; set; }
    }
}
