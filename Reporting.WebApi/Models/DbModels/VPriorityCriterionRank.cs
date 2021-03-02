using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VPriorityCriterionRank
    {
        public Guid Rid { get; set; }
        public Guid Criterion1Id { get; set; }
        public Guid Criterion2Id { get; set; }
        public Guid PersonId { get; set; }
        public string PersonIdCode { get; set; }
        public decimal? RankValue { get; set; }
        public string PersonCode { get; set; }
        public string PersonName { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string PersonPatronymic { get; set; }
        public string PersonDepartment { get; set; }
        public string PersonPost { get; set; }
    }
}
