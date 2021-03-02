using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TaskResultValue
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
        public decimal? OldProposedValue { get; set; }
        public DateTime? OldProposedDateFrom { get; set; }
        public DateTime? OldProposedDateTo { get; set; }
        public Guid? OldProposedDictionaryId { get; set; }
        public Guid? WorkEventId { get; set; }

        public virtual TaskElement TaskElement { get; set; }
        public virtual TaskStep TaskStep { get; set; }
        public virtual VersionVersion Version { get; set; }
    }
}
