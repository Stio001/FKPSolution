using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemAudit
    {
        public Guid Rid { get; set; }
        public string TableName { get; set; }
        public Guid UserRid { get; set; }
        public string ChangeType { get; set; }
        public DateTime ChangeTime { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
