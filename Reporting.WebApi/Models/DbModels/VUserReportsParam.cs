using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VUserReportsParam
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public int? Num { get; set; }
        public string Name { get; set; }
        public int? DataType { get; set; }
        public string SDataType { get; set; }
        public string SLinkType { get; set; }
        public string DataMask { get; set; }
        public int? LinkType { get; set; }
        public Guid? LinkSection { get; set; }
        public string LinksectionCode { get; set; }
        public Guid? LinkField { get; set; }
        public string LinkfieldCode { get; set; }
        public string Label { get; set; }
        public string DefaultValueStr { get; set; }
        public DateTime? DefaultValueDate { get; set; }
        public bool? DefaultValueDateIsCurrent { get; set; }
        public decimal? DefaultValueNum { get; set; }
        public string ProcedureParam { get; set; }
        public bool? IsRid { get; set; }
        public bool? IsCanGetList { get; set; }
        public bool? IsOutput { get; set; }
    }
}
