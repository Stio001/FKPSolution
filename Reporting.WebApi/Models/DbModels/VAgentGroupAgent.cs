using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VAgentGroupAgent
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid AgentId { get; set; }
        public string AgentIdCode { get; set; }
        public string AgentIdName { get; set; }
        public int? OrderNum { get; set; }
        public string AddName { get; set; }
    }
}
