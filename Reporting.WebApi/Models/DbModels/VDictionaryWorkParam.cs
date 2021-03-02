using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkParam
    {
        public Guid? ParentId { get; set; }
        public Guid ParamId { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public string SortNum { get; set; }
        public string Name { get; set; }
        public string TitleName { get; set; }
        public int? LinkType { get; set; }
        public string DefaultValueS { get; set; }
        public Guid? LinkSectionId { get; set; }
        public Guid? LinkFieldId { get; set; }
        public string ParamIdCode { get; set; }
        public string ParamIdName { get; set; }
        public string LinkSectionIdCode { get; set; }
        public string LinkFieldIdAttName { get; set; }
        public string LinkFieldIdAttFieldName { get; set; }
        public string LinkFieldIdCode { get; set; }
        public DateTime? DefaultValueD1 { get; set; }
        public int? DefaultValueN1 { get; set; }
        public DateTime? DefaultValueD2 { get; set; }
        public int? DefaultValueN2 { get; set; }
        public string LinkTypeCode { get; set; }
        public int CalculateType { get; set; }
        public string CalculateTypeCode { get; set; }
        public string Formula { get; set; }
        public string ProcedureName { get; set; }
    }
}
