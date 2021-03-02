using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTargetIndicatorTargetIndicatorWorkPlace
    {
        public Guid Rid { get; set; }
        public Guid? IndicatorId { get; set; }
        public string IndicatorName { get; set; }
        public string IndicatorNum { get; set; }
        public Guid VersionId { get; set; }
        public Guid? VersionIdparent { get; set; }
        public string F0 { get; set; }
        public string F1 { get; set; }
        public string VersionIdCode { get; set; }
        public string VersionIdName { get; set; }
        public int? NYear { get; set; }
        public decimal? Nvalue { get; set; }
        public string MeasureIdCode { get; set; }
        public int? UseInGraph { get; set; }
    }
}
