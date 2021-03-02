using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTechnicParamForTargetIndicator
    {
        public Guid? Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid? VersionId { get; set; }
        public Guid ParamId { get; set; }
        public string ParamIdCode { get; set; }
        public string ParamIdName { get; set; }
        public int? ParamIdDataType { get; set; }
        public string MeasureIdCode { get; set; }
        public string ValueStr { get; set; }
        public decimal? ValueN1 { get; set; }
        public decimal? ValueN2 { get; set; }
        public string ParamValue { get; set; }
        public Guid? DictionaryValueId { get; set; }
        public int? LinkNum { get; set; }
        public string LinkText { get; set; }
        public string ShortName { get; set; }
        public string YearFrom { get; set; }
        public string YearTo { get; set; }
    }
}
