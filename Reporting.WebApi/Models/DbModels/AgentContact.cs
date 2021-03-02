using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class AgentContact
    {
        public Guid Rid { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string ContactValue { get; set; }
        public Guid AgentId { get; set; }
        public Guid ContactTypeId { get; set; }

        public virtual AgentAgent Agent { get; set; }
        public virtual DictionaryDictionary ContactType { get; set; }
    }
}
