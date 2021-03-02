using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class WorkAgent
    {
        public Guid Rid { get; set; }
        public Guid WorkId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Guid AgentId { get; set; }
        public int AgentType { get; set; }
        public int? SortNum { get; set; }
        public Guid? VersionId { get; set; }

        public virtual AgentAgent Agent { get; set; }
        public virtual VersionVersion Version { get; set; }
    }
}
