using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDshbChrt23
    {
        public Guid Rid { get; set; }
        public Guid ParamId { get; set; }
        public short? CalcYear { get; set; }
        public decimal? Value { get; set; }
        public string Description { get; set; }
        public string ParamIdCode { get; set; }
        public string PersonName { get; set; }
        public string PersonUserName { get; set; }
        public string ShortName { get; set; }
        public string ProjectCode { get; set; }
        public string VersionCode { get; set; }
        public Guid VersionId { get; set; }
        public Guid? VersionParentId { get; set; }
    }
}
