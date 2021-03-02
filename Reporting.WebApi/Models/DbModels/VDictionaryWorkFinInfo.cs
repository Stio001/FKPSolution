using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkFinInfo
    {
        public Guid Rid { get; set; }
        public Guid Dwrid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid VersionId { get; set; }
        public string VersionIdCode { get; set; }
        public decimal? SumParam { get; set; }
        public int? NYear { get; set; }
        public int? WorkType { get; set; }
    }
}
