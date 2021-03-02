using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VParamParam
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        public Guid? MeasureId { get; set; }
        public Guid CatalogId { get; set; }
        public string Formula { get; set; }
        public Guid? ProcedureId { get; set; }
        public string MeasureIdCode { get; set; }
        public int DataType { get; set; }
        public string ProcedureIdProcedurename { get; set; }
        public string ProcedureIdCode { get; set; }
        public string DataTypeCode { get; set; }
        public Guid? GroupId { get; set; }
        public string GroupIdCode { get; set; }
        public int? LinkType { get; set; }
        public Guid? LinkSectionId { get; set; }
        public Guid? LinkFieldId { get; set; }
        public string LinktypeName { get; set; }
        public string LinksectionidCode { get; set; }
        public string LinksectionidName { get; set; }
        public string LinkfieldidAttname { get; set; }
        public string LinkfieldidAttfieldname { get; set; }
        public string LinkfieldidAttcaption { get; set; }
    }
}
