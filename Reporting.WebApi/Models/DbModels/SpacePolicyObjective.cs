using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SpacePolicyObjective
    {
        public SpacePolicyObjective()
        {
            SpacePolicyObjectiveDirections = new HashSet<SpacePolicyObjectiveDirection>();
            SpacePolicyObjectiveObjectives = new HashSet<SpacePolicyObjectiveObjective>();
        }

        public Guid Rid { get; set; }
        public int Num { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }

        public virtual ICollection<SpacePolicyObjectiveDirection> SpacePolicyObjectiveDirections { get; set; }
        public virtual ICollection<SpacePolicyObjectiveObjective> SpacePolicyObjectiveObjectives { get; set; }
    }
}
