using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VPriorityCriterionObject
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid ObjectId { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid VersionId { get; set; }
        public string VersionCode { get; set; }
        public string VersionName { get; set; }
        public int VersionStateId { get; set; }
        public string VersionStateName { get; set; }
    }
}
