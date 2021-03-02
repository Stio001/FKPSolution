using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ScenarioMessage
    {
        public Guid Rid { get; set; }
        public Guid ScenarioStageId { get; set; }
        public Guid MessageId { get; set; }
        public Guid MessageTypeId { get; set; }

        public virtual MessageMessage Message { get; set; }
        public virtual DictionaryDictionary MessageType { get; set; }
        public virtual ScenarioStage ScenarioStage { get; set; }
    }
}
