using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryLink
    {
        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public Guid? VersionId { get; set; }
        public int? Num { get; set; }
        public int? AppNum { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual VersionVersion Version { get; set; }
    }
}
