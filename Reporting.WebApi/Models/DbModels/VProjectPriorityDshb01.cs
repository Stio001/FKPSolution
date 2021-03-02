using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VProjectPriorityDshb01
    {
        public Guid Rid { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? BaseRank { get; set; }
        public int? Priority { get; set; }
        public string VersionCode { get; set; }
        public string VersionState { get; set; }
        public decimal? Median { get; set; }
    }
}
