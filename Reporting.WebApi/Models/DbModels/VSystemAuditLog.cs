using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemAuditLog
    {
        public Guid Rid { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public string CallProcedure { get; set; }
        public string CallParams { get; set; }
        public DateTime Date { get; set; }
        public int SessionId { get; set; }
        public string Application { get; set; }
    }
}
