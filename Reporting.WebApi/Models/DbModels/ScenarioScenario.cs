using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ScenarioScenario
    {
        public ScenarioScenario()
        {
            ScenarioStages = new HashSet<ScenarioStage>();
        }

        public Guid Rid { get; set; }
        public string Note { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid CatalogId { get; set; }
        public Guid? TypeId { get; set; }
        public string Description { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual DictionaryDictionary Type { get; set; }
        public virtual ICollection<ScenarioStage> ScenarioStages { get; set; }
    }
}
