using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SpacePolicyObjectiveObjective
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid ObjectiveId { get; set; }

        public virtual ObjectiveObjective Objective { get; set; }
        public virtual SpacePolicyObjective Parent { get; set; }
    }
}
