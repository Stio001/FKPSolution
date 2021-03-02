using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemIssueHistory
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public int StateId { get; set; }
        public DateTime StateDate { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public string Note { get; set; }
        public string StateIdCode { get; set; }
        public string AgentIdCode { get; set; }
    }
}
