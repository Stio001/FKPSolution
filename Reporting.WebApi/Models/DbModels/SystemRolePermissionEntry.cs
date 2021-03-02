using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemRolePermissionEntry
    {
        public Guid RoleId { get; set; }
        public Guid EntryId { get; set; }

        public virtual GlobalGlobalEntry Entry { get; set; }
        public virtual SystemRole Role { get; set; }
    }
}
