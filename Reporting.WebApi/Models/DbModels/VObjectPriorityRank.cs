using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VObjectPriorityRank
    {
        public Guid? Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? VersionId { get; set; }
        public Guid? ObjectId1 { get; set; }
        public Guid? ObjectId2 { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public Guid? ValueRid { get; set; }
        public decimal? RankValue { get; set; }
        public int? NRankValue { get; set; }
        public Guid? PersonId { get; set; }
        public string AgentCode { get; set; }
        public string SValue { get; set; }
        public decimal? NValue { get; set; }
    }
}
