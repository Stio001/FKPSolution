using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemErrorLog
    {
        public Guid Rid { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorSystemDescription { get; set; }
        public DateTime? Date { get; set; }
        public int? ErrorLevel { get; set; }
        public string ProcName { get; set; }
        public string StackTrace { get; set; }
        public int? MessageType { get; set; }
    }
}
