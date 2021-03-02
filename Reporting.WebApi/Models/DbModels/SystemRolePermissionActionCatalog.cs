using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemRolePermissionActionCatalog
    {
        public Guid RoleId { get; set; }
        public Guid ActionId { get; set; }
        public Guid CatalogId { get; set; }
        public bool? Audit { get; set; }

        public virtual GlobalGlobalEntryAttr Action { get; set; }
        public virtual CatalogCatalog Catalog { get; set; }
        public virtual SystemRole Role { get; set; }
    }
}
