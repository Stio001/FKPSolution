using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VProjectTargetIndicator
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid IndicatorId { get; set; }
        public string IndicatorIdCode { get; set; }
        public string IndicatorIdName { get; set; }
        public string ShortName { get; set; }
        public Guid? VersionId { get; set; }
        public decimal? Koeff { get; set; }
    }
}
