using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemUserPermissionEntry
    {
        public Guid UserId { get; set; }
        public Guid EntryId { get; set; }

        public virtual GlobalGlobalEntry Entry { get; set; }
        public virtual SystemUser User { get; set; }
    }
}
