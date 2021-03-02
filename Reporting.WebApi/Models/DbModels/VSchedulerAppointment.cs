using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSchedulerAppointment
    {
        public Guid Rid { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? AllDay { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? Label { get; set; }
        public string ReminderInfo { get; set; }
        public string RecurrenceInfo { get; set; }
        public int? PercentComplete { get; set; }
        public int? IsPrivate { get; set; }
        public string OwnerId { get; set; }
        public string Color { get; set; }
        public Guid? ParentId { get; set; }
    }
}
