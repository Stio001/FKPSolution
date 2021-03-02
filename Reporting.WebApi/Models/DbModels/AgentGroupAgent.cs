using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class AgentGroupAgent
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid AgentId { get; set; }
        public int? OrderNum { get; set; }

        public virtual AgentAgent Agent { get; set; }
        public virtual AgentGroupGroup Parent { get; set; }
    }
}
