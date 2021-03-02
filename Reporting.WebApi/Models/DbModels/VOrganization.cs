using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VOrganization
    {
        public Guid Rid { get; set; }
        public Guid AgentId { get; set; }
        public string AgentIdCode { get; set; }
        public string Code { get; set; }
        public string Note { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
