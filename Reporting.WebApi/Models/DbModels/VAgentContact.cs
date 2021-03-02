using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VAgentContact
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string ContactValue { get; set; }
        public Guid AgentId { get; set; }
        public Guid ContactTypeId { get; set; }
        public string ContactTypeIdCode { get; set; }
        public string ContactTypeIdName { get; set; }
    }
}
