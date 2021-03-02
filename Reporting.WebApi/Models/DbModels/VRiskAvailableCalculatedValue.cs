using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VRiskAvailableCalculatedValue
    {
        public Guid Rid { get; set; }
        public string ItemType { get; set; }
        public string ItemCode { get; set; }
        public Guid? ProjectId { get; set; }
        public string ProjectIdNum { get; set; }
        public Guid ParamId { get; set; }
        public DateTime? CalcDate { get; set; }
        public short? CalcYear { get; set; }
        public decimal? Value { get; set; }
        public string Description { get; set; }
        public string ParamIdCode { get; set; }
        public bool? IsBasic { get; set; }
        public bool? IsActual { get; set; }
        public Guid? VersionId { get; set; }
        public Guid? AgentId { get; set; }
        public string PersonName { get; set; }
        public string PersonUserName { get; set; }
        public bool? IsManual { get; set; }
        public string ShortName { get; set; }
        public string Protocol { get; set; }
    }
}
