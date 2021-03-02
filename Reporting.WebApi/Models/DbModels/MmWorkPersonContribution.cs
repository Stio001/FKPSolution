using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class MmWorkPersonContribution
    {
        public Guid Rid { get; set; }
        public Guid StageId { get; set; }
        public Guid PersonId { get; set; }
        public decimal ContributionValue { get; set; }
        public DateTime CalcDate { get; set; }
        public decimal? PersonRaiting { get; set; }

        public virtual AgentPerson Person { get; set; }
        public virtual MmWorkStage Stage { get; set; }
    }
}
