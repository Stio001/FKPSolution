using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTechnicTypeParam
    {
        public Guid Rid { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public int? SortNum { get; set; }
        public Guid ParentId { get; set; }
        public Guid ParamId { get; set; }
        public string ParamIdCode { get; set; }
        public string ParamIdName { get; set; }
        public int? ParamIdDataType { get; set; }
        public string DataType { get; set; }
        public string ValueStr { get; set; }
        public string ParamValue { get; set; }
        public Guid? DictionaryValueId { get; set; }
        public int? LinkNum { get; set; }
        public string LinkText { get; set; }
        public Guid? VersionId { get; set; }
        public string VersionIdCode { get; set; }
        public string VersionIdName { get; set; }
        public string MeasureIdCode { get; set; }
        public string ShortName { get; set; }
    }
}
