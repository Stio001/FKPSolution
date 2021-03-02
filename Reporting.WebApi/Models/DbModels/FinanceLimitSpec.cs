using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class FinanceLimitSpec
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid? WorkSectionId { get; set; }
        public decimal? NSum { get; set; }
        public DateTime? ChangeDate { get; set; }

        public virtual FinanceLimit Parent { get; set; }
        public virtual WorkSection WorkSection { get; set; }
    }
}
