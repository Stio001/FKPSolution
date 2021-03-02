using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemUserPermissionActionCatalog
    {
        public Guid Rid { get; set; }
        public Guid UserId { get; set; }
        public Guid ActionId { get; set; }
        public Guid CatalogId { get; set; }

        public virtual GlobalGlobalEntryAttr Action { get; set; }
        public virtual CatalogCatalog Catalog { get; set; }
        public virtual SystemUser User { get; set; }
    }
}
