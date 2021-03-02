using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class FinanceLimit
    {
        public FinanceLimit()
        {
            FinanceLimitSpecs = new HashSet<FinanceLimitSpec>();
        }

        public Guid Rid { get; set; }
        public Guid VersionId { get; set; }
        public int NYear { get; set; }
        public decimal? NSum { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Note { get; set; }
        public decimal? NSum1 { get; set; }
        public decimal? NSum2 { get; set; }
        public decimal? NSum3 { get; set; }

        public virtual ICollection<FinanceLimitSpec> FinanceLimitSpecs { get; set; }
    }
}
