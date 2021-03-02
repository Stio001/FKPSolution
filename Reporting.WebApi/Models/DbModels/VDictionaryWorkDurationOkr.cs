using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkDurationOkr
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string VersionIdCode { get; set; }
        public string WorkCodeIdCode { get; set; }
        public int? YearFrom { get; set; }
        public int? YearTo { get; set; }
        public int? Duration { get; set; }
        public Guid VersionId { get; set; }
    }
}
