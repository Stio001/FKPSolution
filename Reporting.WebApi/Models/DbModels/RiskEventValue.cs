using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class RiskEventValue
    {
        public Guid Rid { get; set; }
        public Guid DictionaryWorkRiskEventId { get; set; }
        public Guid PersonId { get; set; }
        public decimal ValueP { get; set; }
        public string RiskReason { get; set; }
        public decimal DamageValueR { get; set; }
        public decimal DamageValueT { get; set; }
        public decimal DamageValueS { get; set; }
        public string DamageReasonR { get; set; }
        public string DamageReasonT { get; set; }
        public string DamageReasonS { get; set; }
        public string Note { get; set; }

        public virtual DictionaryWorkRiskEvent DictionaryWorkRiskEvent { get; set; }
        public virtual AgentPerson Person { get; set; }
    }
}
