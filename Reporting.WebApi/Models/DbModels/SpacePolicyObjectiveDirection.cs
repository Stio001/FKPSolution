using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SpacePolicyObjectiveDirection
    {
        public Guid Rid { get; set; }
        public Guid ObjectiveId { get; set; }
        public Guid WorkDirectionId { get; set; }
        public Guid VersionId { get; set; }
        public decimal Priority { get; set; }

        public virtual SpacePolicyObjective Objective { get; set; }
        public virtual VersionVersion Version { get; set; }
        public virtual WorkDirection WorkDirection { get; set; }
    }
}
