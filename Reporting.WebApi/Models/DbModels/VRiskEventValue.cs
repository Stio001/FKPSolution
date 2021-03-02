using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VRiskEventValue
    {
        public Guid? Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid? PersonId { get; set; }
        public decimal? ValueP { get; set; }
        public string RiskReason { get; set; }
        public decimal? DamageValueR { get; set; }
        public decimal? DamageValueT { get; set; }
        public decimal? DamageValueS { get; set; }
        public string DamageReasonR { get; set; }
        public string DamageReasonT { get; set; }
        public string DamageReasonS { get; set; }
        public string Note { get; set; }
        public string TabNum { get; set; }
        public string PersonIdCode { get; set; }
        public string PostCode { get; set; }
        public string PostName { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public decimal? ProffKoef { get; set; }
        public string PersonUserName { get; set; }
        public string RiskValueDescription { get; set; }
        public string DamageCharR { get; set; }
        public string DamageCharT { get; set; }
        public string DamageCharS { get; set; }
    }
}
