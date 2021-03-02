using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VFinanceLimitSpec
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public decimal? NSum { get; set; }
        public Guid? WorkSectionId { get; set; }
        public string WorkSectionIdCode { get; set; }
        public string WorkSectionIdName { get; set; }
        public DateTime? ChangeDate { get; set; }
        public decimal? MainSum { get; set; }
    }
}
