using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class WorkDirection
    {
        public WorkDirection()
        {
            SpacePolicyObjectiveDirections = new HashSet<SpacePolicyObjectiveDirection>();
            WorkDirectionParams = new HashSet<WorkDirectionParam>();
        }

        public Guid Rid { get; set; }
        public string Numb { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SpacePolicyObjectiveDirection> SpacePolicyObjectiveDirections { get; set; }
        public virtual ICollection<WorkDirectionParam> WorkDirectionParams { get; set; }
    }
}
