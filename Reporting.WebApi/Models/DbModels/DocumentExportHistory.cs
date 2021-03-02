using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DocumentExportHistory
    {
        public Guid Rid { get; set; }
        public Guid? DocumentId { get; set; }
        public string Note { get; set; }
        public Guid? AgentFromId { get; set; }
        public int? StateId { get; set; }
        public DateTime? ExportDate { get; set; }
        public string UserName { get; set; }
        public Guid? AgentToId { get; set; }
        public string Email { get; set; }

        public virtual AgentAgent AgentFrom { get; set; }
        public virtual AgentAgent AgentTo { get; set; }
    }
}
