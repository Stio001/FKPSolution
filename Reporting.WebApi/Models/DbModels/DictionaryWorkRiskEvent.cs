using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryWorkRiskEvent
    {
        public DictionaryWorkRiskEvent()
        {
            RiskEventValues = new HashSet<RiskEventValue>();
        }

        public Guid Rid { get; set; }
        public Guid DictionaryWorkId { get; set; }
        public Guid DictionaryRiskId { get; set; }
        public Guid VersionId { get; set; }
        public string Note { get; set; }

        public virtual DictionaryRisk DictionaryRisk { get; set; }
        public virtual VersionVersion Version { get; set; }
        public virtual ICollection<RiskEventValue> RiskEventValues { get; set; }
    }
}
