using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class WorkParam
    {
        public Guid Rid { get; set; }
        public Guid ParamId { get; set; }
        public Guid WorkId { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public string SortNum { get; set; }
        public int? RowNum { get; set; }
        public string Name { get; set; }
        public string TitleName { get; set; }
        public int? LinkType { get; set; }
        public DateTime? DefaultValueD1 { get; set; }
        public string DefaultValueS { get; set; }
        public int? DefaultValueN1 { get; set; }
        public int? ColNum { get; set; }
        public Guid? VersionId { get; set; }
        public Guid? LinkSectionId { get; set; }
        public Guid? LinkFieldId { get; set; }
        public DateTime? DefaultValueD2 { get; set; }
        public int? DefaultValueN2 { get; set; }
        public int CalculateType { get; set; }

        public virtual GlobalGlobalEntryAttr LinkField { get; set; }
        public virtual GlobalGlobalEntry LinkSection { get; set; }
        public virtual ParamParam Param { get; set; }
        public virtual VersionVersion Version { get; set; }
    }
}
