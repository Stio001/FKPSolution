using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class StructureAgentGroup
    {
        public Guid Rid { get; set; }
        public Guid StructureId { get; set; }
        public Guid AgentGroupId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        public virtual SystemRole AgentGroup { get; set; }
        public virtual StructureStructure Structure { get; set; }
    }
}
