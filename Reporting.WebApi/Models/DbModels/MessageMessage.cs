using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class MessageMessage
    {
        public MessageMessage()
        {
            ScenarioMessages = new HashSet<ScenarioMessage>();
        }

        public Guid Rid { get; set; }
        public string Note { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid CatalogId { get; set; }
        public string MassageText { get; set; }
        public Guid TypeId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual DictionaryDictionary Type { get; set; }
        public virtual ICollection<ScenarioMessage> ScenarioMessages { get; set; }
    }
}
