using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDshbChrt30
    {
        public string Code { get; set; }
        public int? PlanDateFrom { get; set; }
        public Guid? VersionId { get; set; }
        public string VersionCode { get; set; }
        public int? Cnt { get; set; }
    }
}
