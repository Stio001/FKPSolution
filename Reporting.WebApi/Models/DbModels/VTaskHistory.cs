using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTaskHistory
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid? ElementId { get; set; }
        public string ElementIdCode { get; set; }
        public string UserName { get; set; }
        public DateTime? StateDate { get; set; }
        public TimeSpan? StateTime { get; set; }
        public string Content { get; set; }
        public string PersonIdCode { get; set; }
        public short? ActionType { get; set; }
        public string ActionTypeCode { get; set; }
    }
}
