using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class PriorityCriterionRank
    {
        public Guid Rid { get; set; }
        public Guid Criterion1Id { get; set; }
        public Guid Criterion2Id { get; set; }
        public Guid PersonId { get; set; }
        public decimal? RankValue { get; set; }
        public Guid? VersionId { get; set; }
        public Guid? ParentId { get; set; }
        public int? NRankValue { get; set; }
        public DateTime? RankDate { get; set; }

        public virtual AgentPerson Person { get; set; }
        public virtual VersionVersion Version { get; set; }
    }
}
