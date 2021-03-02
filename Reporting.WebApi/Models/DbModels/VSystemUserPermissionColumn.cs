using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemUserPermissionColumn
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public Guid ColumnId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnArea { get; set; }
        public bool? HasPermission { get; set; }
        public bool? Editable { get; set; }
    }
}
