using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VWorkPriorityDshb01
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string ProgNum { get; set; }
        public string RegNum { get; set; }
        public string WorkCodeCode { get; set; }
        public decimal? Rank { get; set; }
        public decimal? BaseRank { get; set; }
        public decimal? Priority { get; set; }
        public string VersionCode { get; set; }
        public string VersionState { get; set; }
        public decimal? Median { get; set; }
    }
}
