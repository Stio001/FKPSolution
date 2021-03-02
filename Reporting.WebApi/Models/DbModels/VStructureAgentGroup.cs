using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VStructureAgentGroup
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid AgentGroupId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string AgentGroupIdCode { get; set; }
    }
}
