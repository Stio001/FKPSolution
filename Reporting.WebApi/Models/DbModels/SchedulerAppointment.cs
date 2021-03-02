using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SchedulerAppointment
    {
        public Guid Rid { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? AllDay { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public int? Label { get; set; }
        public string ReminderInfo { get; set; }
        public string RecurrenceInfo { get; set; }
        public int? PercentComplete { get; set; }
        public bool? IsPrivate { get; set; }
        public string OwnerId { get; set; }
        public string Color { get; set; }
        public Guid? ParentId { get; set; }
    }
}
