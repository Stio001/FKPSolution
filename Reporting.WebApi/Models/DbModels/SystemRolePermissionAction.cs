using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemRolePermissionAction
    {
        public Guid RoleId { get; set; }
        public Guid ActionId { get; set; }
        public bool? Audit { get; set; }

        public virtual GlobalGlobalEntryAttr Action { get; set; }
        public virtual SystemRole Role { get; set; }
    }
}
