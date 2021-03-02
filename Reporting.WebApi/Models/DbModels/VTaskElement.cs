using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTaskElement
    {
        public Guid Rid { get; set; }
        public Guid TaskId { get; set; }
        public Guid ElementId { get; set; }
        public string ElementValue { get; set; }
        public int? ElementValueDataType { get; set; }
        public string TaskText { get; set; }
        public int ChangeType { get; set; }
        public int State { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string StateName { get; set; }
        public string Name { get; set; }
        public string StructurePath { get; set; }
        public string EventTypeIdCode { get; set; }
        public string ElementTypeCode { get; set; }
        public string ElementTypeName { get; set; }
        public decimal? ElementValue1 { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string GroupName { get; set; }
        public string MeasureIdCode { get; set; }
        public string DictionaryValueIdCode { get; set; }
        public Guid? DictionaryValueId { get; set; }
        public string ChangeTypeCode { get; set; }
        public int? ExternalDocCount { get; set; }
        public string UserName { get; set; }
        public string PersonIdCode { get; set; }
        public string WorkCodeIdCode { get; set; }
    }
}
