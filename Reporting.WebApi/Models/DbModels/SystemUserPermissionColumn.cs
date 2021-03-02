using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemUserPermissionColumn
    {
        public Guid UserId { get; set; }
        public Guid ColumnId { get; set; }
        public bool Editable { get; set; }

        public virtual GlobalGlobalEntryAttr Column { get; set; }
        public virtual SystemUser User { get; set; }
    }
}
