using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTaskResultValue
    {
        public Guid Rid { get; set; }
        public Guid TaskElementId { get; set; }
        public Guid TaskStepId { get; set; }
        public decimal? ProposedValue { get; set; }
        public DateTime? ProposedDateFrom { get; set; }
        public DateTime? ProposedDateTo { get; set; }
        public Guid? ProposedDictionaryId { get; set; }
        public int Variant { get; set; }
        public int State { get; set; }
        public Guid? VersionId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string VersionCode { get; set; }
        public string VersionIdCode { get; set; }
        public string StateName { get; set; }
        public Guid ElementId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid? DictionaryValueId { get; set; }
        public string DictionaryValueIdCode { get; set; }
        public decimal? ElementValue { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ElementTypeCode { get; set; }
        public string ElementTypeName { get; set; }
        public string ProposedDictionaryIdCode { get; set; }
        public decimal? OldValue { get; set; }
        public DateTime? OldDateFrom { get; set; }
        public DateTime? OldDateTo { get; set; }
        public Guid? OldDic { get; set; }
        public string OldDictionaryIdCode { get; set; }
        public Guid TaskId { get; set; }
        public int? ExternalDocCount { get; set; }
    }
}
