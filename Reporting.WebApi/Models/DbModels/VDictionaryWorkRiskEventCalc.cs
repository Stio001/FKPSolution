using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkRiskEventCalc
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid DictionaryRiskId { get; set; }
        public Guid VersionId { get; set; }
        public string Note { get; set; }
        public string DictionaryRiskIdCode { get; set; }
        public string DictionaryRiskIdName { get; set; }
        public string DictionaryRiskTypeIdCode { get; set; }
        public decimal? ValueP { get; set; }
        public decimal? DamageValueR { get; set; }
        public decimal? DamageValueT { get; set; }
        public decimal? DamageValueS { get; set; }
    }
}
