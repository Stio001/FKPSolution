using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class UserApplicationApplication
    {
        public Guid Rid { get; set; }
        public string Note { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public Guid CatalogId { get; set; }
        public byte[] Application { get; set; }
        public string Version { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
    }
}
