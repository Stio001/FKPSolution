using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryWorkEvent
    {
        public DictionaryWorkEvent()
        {
            DictionaryWorkEventFinEvents = new HashSet<DictionaryWorkEventFin>();
            DictionaryWorkEventFinFins = new HashSet<DictionaryWorkEventFin>();
            DictionaryWorkEventTechnics = new HashSet<DictionaryWorkEventTechnic>();
            InverseParentEvent = new HashSet<DictionaryWorkEvent>();
            ParamValueResults = new HashSet<ParamValueResult>();
        }

        public Guid Rid { get; set; }
        public Guid DictionaryWorkId { get; set; }
        public Guid? VersionId { get; set; }
        public string Name { get; set; }
        public Guid EventTypeId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid? DictionaryValueId { get; set; }
        public decimal? Value { get; set; }
        public Guid? ParentEventId { get; set; }
        public bool? UseInCalc { get; set; }
        public int? OrderNum { get; set; }
        public Guid? MeasureId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Guid? SpacecraftId { get; set; }
        public decimal? EventPercent { get; set; }
        public bool? IsAnnualy { get; set; }
        public bool? IsDone { get; set; }
        public bool? IsChild { get; set; }

        public virtual DictionaryEventType EventType { get; set; }
        public virtual DictionaryMeasure Measure { get; set; }
        public virtual DictionaryWorkEvent ParentEvent { get; set; }
        public virtual SpacecraftSpacecraft Spacecraft { get; set; }
        public virtual VersionVersion Version { get; set; }
        public virtual ICollection<DictionaryWorkEventFin> DictionaryWorkEventFinEvents { get; set; }
        public virtual ICollection<DictionaryWorkEventFin> DictionaryWorkEventFinFins { get; set; }
        public virtual ICollection<DictionaryWorkEventTechnic> DictionaryWorkEventTechnics { get; set; }
        public virtual ICollection<DictionaryWorkEvent> InverseParentEvent { get; set; }
        public virtual ICollection<ParamValueResult> ParamValueResults { get; set; }
    }
}
