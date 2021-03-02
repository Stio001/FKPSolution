using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDshbChrt28
    {
        public int? NYear { get; set; }
        public int Cnt { get; set; }
        public string Code { get; set; }
        public Guid VersionId { get; set; }
        public string VersionIdCode { get; set; }
    }
}
