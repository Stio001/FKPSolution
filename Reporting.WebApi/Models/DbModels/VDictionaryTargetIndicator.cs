using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryTargetIndicator
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? Priority { get; set; }
        public Guid? MeasureId { get; set; }
        public string MeasureIdCode { get; set; }
        public string MeasureIdShortCode { get; set; }
        public string SFormat { get; set; }
        public Guid? VersionId { get; set; }
        public short? TrendType { get; set; }
        public string TrendTypeCode { get; set; }
        public Guid? ParentId { get; set; }
        public string ElementTypeCode { get; set; }
        public int? ElementType { get; set; }
        public bool? CalcMethod { get; set; }
        public string ProcedureName { get; set; }
        public bool? IsPrint { get; set; }
        public bool? ManualEdit { get; set; }
        public bool? IsCalcEfficiency { get; set; }
        public string ShortName { get; set; }
        public bool? IsUpdate { get; set; }
    }
}
