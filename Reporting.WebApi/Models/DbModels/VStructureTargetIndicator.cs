using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VStructureTargetIndicator
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid IndicatorId { get; set; }
        public Guid ProjectId { get; set; }
        public decimal? Koeff { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string IndicatorIdCode { get; set; }
        public bool? IsCalcEfficiency { get; set; }
    }
}
