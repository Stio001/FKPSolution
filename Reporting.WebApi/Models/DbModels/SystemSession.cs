using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemSession
    {
        public Guid Rid { get; set; }
        public int SessionId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime PrevActionTime { get; set; }
        public DateTime? LastActionTime { get; set; }
        public int Duration { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public bool? IsNormal { get; set; }
    }
}
