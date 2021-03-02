using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ScenarioStage
    {
        public ScenarioStage()
        {
            ScenarioHistories = new HashSet<ScenarioHistory>();
            ScenarioMessages = new HashSet<ScenarioMessage>();
        }

        public Guid Rid { get; set; }
        public string Note { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ScenarioId { get; set; }
        public int? Num { get; set; }
        public Guid? AgentId { get; set; }
        public int? ResultTypeId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string ResultValue { get; set; }

        public virtual AgentAgent Agent { get; set; }
        public virtual ScenarioScenario Scenario { get; set; }
        public virtual ICollection<ScenarioHistory> ScenarioHistories { get; set; }
        public virtual ICollection<ScenarioMessage> ScenarioMessages { get; set; }
    }
}
