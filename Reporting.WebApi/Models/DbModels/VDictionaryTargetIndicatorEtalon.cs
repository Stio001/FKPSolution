using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryTargetIndicatorEtalon
    {
        public Guid IndicatorId { get; set; }
        public string Code { get; set; }
        public Guid? VersionId { get; set; }
        public string IndicatorNum { get; set; }
        public string IndicatorName { get; set; }
        public string SFormat { get; set; }
        public Guid? MeasureId { get; set; }
        public string MeasureIdCode { get; set; }
        public string F0 { get; set; }
        public string F1 { get; set; }
        public int? Variant { get; set; }
    }
}
