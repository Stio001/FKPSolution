using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TargetIndicatorValue
    {
        public Guid Rid { get; set; }
        public Guid? IndicatorId { get; set; }
        public string IndicatorName { get; set; }
        public string IndicatorNum { get; set; }
        public Guid VersionId { get; set; }
        public int? Variant { get; set; }
        public string F0 { get; set; }
        public string F1 { get; set; }
        public decimal? Y0 { get; set; }
        public decimal? Y1 { get; set; }
        public decimal? Y2 { get; set; }
        public decimal? Y3 { get; set; }
        public decimal? Y4 { get; set; }
        public decimal? Y5 { get; set; }
        public decimal? Y6 { get; set; }
        public decimal? Y7 { get; set; }
        public decimal? Y8 { get; set; }
        public decimal? Y9 { get; set; }
        public decimal? Y10 { get; set; }
    }
}
