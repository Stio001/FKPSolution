using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class EventMessage
    {
        public Guid Rid { get; set; }
        public Guid? EventId { get; set; }
        public Guid VersionId { get; set; }
        public string MessageText { get; set; }
        public DateTime EventDate { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public bool? IsActual { get; set; }
        public DateTime? EventEndDate { get; set; }
        public short? EventType { get; set; }
        public decimal? EventValue { get; set; }
        public short? EventYear { get; set; }
    }
}
