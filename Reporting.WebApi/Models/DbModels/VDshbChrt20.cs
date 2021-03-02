using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDshbChrt20
    {
        public string ObjectType { get; set; }
        public string GroupCode { get; set; }
        public decimal? Num { get; set; }
        public string VersionCode { get; set; }
        public int? TotalCount { get; set; }
    }
}
