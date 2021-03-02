using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class HistoryState
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? AgentId { get; set; }
        public int? State { get; set; }
        public DateTime? StateDate { get; set; }
        public string UserName { get; set; }
        public string Note { get; set; }

        public virtual AgentAgent Agent { get; set; }
    }
}
