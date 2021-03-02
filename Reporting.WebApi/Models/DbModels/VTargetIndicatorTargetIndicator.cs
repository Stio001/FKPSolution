using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTargetIndicatorTargetIndicator
    {
        public Guid Rid { get; set; }
        public Guid? IndicatorId { get; set; }
        public string IndicatorNum { get; set; }
        public Guid VersionId { get; set; }
        public Guid? VersionIdparent { get; set; }
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
        public string VersionIdCode { get; set; }
        public string VersionIdName { get; set; }
        public string IndicatorName { get; set; }
        public decimal? Priority { get; set; }
        public string SFormat { get; set; }
        public string MeasureIdCode { get; set; }
        public string SY0 { get; set; }
        public string SY1 { get; set; }
        public string SY2 { get; set; }
        public string SY3 { get; set; }
        public string SY4 { get; set; }
        public string SY5 { get; set; }
        public string SY6 { get; set; }
        public string SY7 { get; set; }
        public string SY8 { get; set; }
        public string SY9 { get; set; }
        public string SY10 { get; set; }
        public bool? ManualEdit { get; set; }
        public int? UseInGraph { get; set; }
        public string F0Print { get; set; }
    }
}
