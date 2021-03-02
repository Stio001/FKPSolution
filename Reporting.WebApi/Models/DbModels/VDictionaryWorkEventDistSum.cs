using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkEventDistSum
    {
        public Guid Rid { get; set; }
        public Guid FinId { get; set; }
        public Guid EventId { get; set; }
        public decimal? NSum { get; set; }
        public string FinName { get; set; }
        public string EventName { get; set; }
        public Guid? VersionId { get; set; }
        public Guid ParentId { get; set; }
        public DateTime? DateTo { get; set; }
        public string MeasureIdCode { get; set; }
        public DateTime? EventDateTo { get; set; }
    }
}
