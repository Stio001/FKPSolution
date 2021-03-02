using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDshbChrt29
    {
        public int? DateTo { get; set; }
        public decimal? Value { get; set; }
        public string SectionPath { get; set; }
        public Guid? VersionId { get; set; }
        public string Code { get; set; }
    }
}
