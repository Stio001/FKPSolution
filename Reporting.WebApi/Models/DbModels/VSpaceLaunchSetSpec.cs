using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSpaceLaunchSetSpec
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid KaRid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string ShortName { get; set; }
        public string TypeIdCode { get; set; }
        public string StateIdCode { get; set; }
        public bool? FlightModel { get; set; }
        public string CategoryIdCode { get; set; }
        public string SpaceSystemCode { get; set; }
        public string KkCode { get; set; }
        public string KkName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? FactWorkTime { get; set; }
        public decimal? PlanSas { get; set; }
    }
}
