using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VElementForTask
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string EventTypeIdCode { get; set; }
        public string GroupName { get; set; }
        public decimal? ElementValue { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string MeasureIdCode { get; set; }
        public Guid? DictionaryValueId { get; set; }
        public string DictionaryValueIdCode { get; set; }
        public string ElementTypeCode { get; set; }
        public string ElementTypeName { get; set; }
        public Guid? VersionId { get; set; }
        public string WorkCodeIdCode { get; set; }
    }
}
