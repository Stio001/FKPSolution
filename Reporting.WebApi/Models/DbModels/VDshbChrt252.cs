using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDshbChrt252
    {
        public string VersionCode { get; set; }
        public int? NYear { get; set; }
        public decimal? Value { get; set; }
        public string GostCode { get; set; }
        public string KindCode { get; set; }
        public string TypeCode { get; set; }
        public string SectionCode { get; set; }
    }
}
