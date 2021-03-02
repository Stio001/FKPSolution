using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemSession
    {
        public Guid Rid { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public DateTime LoginTime { get; set; }
        public int SessionId { get; set; }
        public int? Duration { get; set; }
        public string RoleIdCode { get; set; }
    }
}
