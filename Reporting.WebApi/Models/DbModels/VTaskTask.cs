using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTaskTask
    {
        public Guid Rid { get; set; }
        public Guid? VersionId { get; set; }
        public int? Num { get; set; }
        public string RegNum { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? TaskTypeId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid? StageId { get; set; }
        public int State { get; set; }
        public string TaskText { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string StageIdCode { get; set; }
        public string VersionIdCode { get; set; }
        public string CustomerIdCode { get; set; }
        public string StateCode { get; set; }
        public string TaskTypeIdCode { get; set; }
        public int? TaskPeriod { get; set; }
        public int? CountElement { get; set; }
        public string DelayReason { get; set; }
        public int? Delay { get; set; }
        public DateTime? ExecDate { get; set; }
        public int? ExternalDocCount { get; set; }
        public int? CountResult { get; set; }
        public Guid? SeniorWorks { get; set; }
        public string SeniorWorksCode { get; set; }
    }
}
