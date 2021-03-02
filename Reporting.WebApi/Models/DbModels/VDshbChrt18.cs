using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDshbChrt18
    {
        public string ParamCode { get; set; }
        public string ParamShortName { get; set; }
        public string ParamName { get; set; }
        public string VersionCode { get; set; }
        public string VersionName { get; set; }
        public decimal? Value { get; set; }
        public Guid? VersionId { get; set; }
        public short? CalcYear { get; set; }
        public Guid ParamId { get; set; }
    }
}
