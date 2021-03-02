using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ProjectPlanFinDistribution
    {
        public Guid Rid { get; set; }
        public Guid ProjectId { get; set; }
        public Guid PlanVersionId { get; set; }
        public decimal? Sum1 { get; set; }
        public decimal? Sum2 { get; set; }
        public decimal? Sum3 { get; set; }
        public decimal? Sum4 { get; set; }
        public decimal? Sum5 { get; set; }
        public decimal? Sum6 { get; set; }
        public decimal? Sum7 { get; set; }
        public decimal? Sum8 { get; set; }
        public decimal? Sum9 { get; set; }
        public decimal? Sum10 { get; set; }

        public virtual VersionVersion PlanVersion { get; set; }
        public virtual ProjectProject Project { get; set; }
    }
}
