using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemRolePermissionColumn
    {
        public Guid RoleId { get; set; }
        public Guid ColumnId { get; set; }
        public bool Editable { get; set; }

        public virtual GlobalGlobalEntryAttr Column { get; set; }
        public virtual SystemRole Role { get; set; }
    }
}
