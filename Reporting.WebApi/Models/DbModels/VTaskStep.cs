using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTaskStep
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public int Num { get; set; }
        public string TaskText { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid UserFromId { get; set; }
        public Guid? RoleToId { get; set; }
        public Guid? UserToId { get; set; }
        public int State { get; set; }
        public string Answer { get; set; }
        public string Note { get; set; }
        public string UserFromIdCode { get; set; }
        public string RoleToIdCode { get; set; }
        public string UserToIdCode { get; set; }
        public string StateCode { get; set; }
        public int? TaskPeriod { get; set; }
        public DateTime? ExecDate { get; set; }
        public int? Delay { get; set; }
        public int? CountElement { get; set; }
        public int? CountResult { get; set; }
        public int? ExternalDocCount { get; set; }
        public string UserName { get; set; }
        public string DelayReason { get; set; }
    }
}
