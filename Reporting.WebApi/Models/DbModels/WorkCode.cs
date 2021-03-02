using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class WorkCode
    {
        public WorkCode()
        {
            DictionaryWorks = new HashSet<DictionaryWork>();
            WorkWorks = new HashSet<WorkWork>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Guid CatalogId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual ICollection<DictionaryWork> DictionaryWorks { get; set; }
        public virtual ICollection<WorkWork> WorkWorks { get; set; }
    }
}
