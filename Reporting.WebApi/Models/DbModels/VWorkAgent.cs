using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VWorkAgent
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Guid AgentId { get; set; }
        public int AgentType { get; set; }
        public string AgentIdCode { get; set; }
        public string AgentIdName { get; set; }
        public string AgentTypeCode { get; set; }
        public int? SortNum { get; set; }
        public string VersionIdCode { get; set; }
        public string VersionIdName { get; set; }
        public Guid? VersionId { get; set; }
    }
}
