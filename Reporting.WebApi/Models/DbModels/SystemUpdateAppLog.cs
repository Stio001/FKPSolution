using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemUpdateAppLog
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? HostName { get; set; }
        public string UserName { get; set; }
        public DateTime? DateLog { get; set; }
        public int? ResultInt { get; set; }
        public string ResultMsg { get; set; }
    }
}
