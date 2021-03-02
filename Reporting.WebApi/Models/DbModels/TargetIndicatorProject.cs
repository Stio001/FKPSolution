using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TargetIndicatorProject
    {
        public Guid Rid { get; set; }
        public Guid IndicatorId { get; set; }
        public Guid ProjectId { get; set; }
        public decimal? Koeff { get; set; }

        public virtual DictionaryTargetIndicator Indicator { get; set; }
        public virtual ProjectProject Project { get; set; }
    }
}
