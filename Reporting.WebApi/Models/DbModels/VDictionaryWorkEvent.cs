using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkEvent
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid? VersionId { get; set; }
        public string Name { get; set; }
        public Guid EventTypeId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? Value { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int? OrderNum { get; set; }
        public bool? UseInCalc { get; set; }
        public Guid? ParentEventId { get; set; }
        public Guid? MeasureId { get; set; }
        public string MeasureIdCode { get; set; }
        public string VersionIdCode { get; set; }
        public string DictionaryValueIdCode { get; set; }
        public string EventTypeIdCode { get; set; }
        public string EventTypeIdShortCode { get; set; }
        public string Name1 { get; set; }
        public string GroupName { get; set; }
        public string SpaceCraftIdCode { get; set; }
        public Guid? SpacecraftId { get; set; }
        public decimal? EventPercent { get; set; }
        public decimal? StageSum { get; set; }
        public bool? IsAnnualy { get; set; }
        public int? LinkCount { get; set; }
        public int? IsDone { get; set; }
    }
}
