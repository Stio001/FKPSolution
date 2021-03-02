using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkRiskEvent
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid DictionaryRiskId { get; set; }
        public Guid VersionId { get; set; }
        public string Note { get; set; }
        public string DictionaryRiskIdCode { get; set; }
        public string DictionaryRiskIdName { get; set; }
        public string DictionaryRiskTypeIdCode { get; set; }
        public string DictionaryRiskTypeIdName { get; set; }
        public Guid DictionaryRiskTypeId { get; set; }
        public decimal? ValueP { get; set; }
        public decimal? DamageValueR { get; set; }
        public decimal? DamageValueT { get; set; }
        public decimal? DamageValueS { get; set; }
        public decimal? R12 { get; set; }
        public decimal? R13 { get; set; }
        public decimal? R21 { get; set; }
        public decimal? R23 { get; set; }
        public decimal? R31 { get; set; }
        public decimal? R32 { get; set; }
        public string RiskValueDescription { get; set; }
        public string RiskReason { get; set; }
        public string DamageReasonR { get; set; }
        public string DamageReasonT { get; set; }
        public string DamageReasonS { get; set; }
        public int? ValueCount { get; set; }
    }
}
