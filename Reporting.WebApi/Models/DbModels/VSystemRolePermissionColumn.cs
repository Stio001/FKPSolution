using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemRolePermissionColumn
    {
        public Guid? RoleId { get; set; }
        public string RoleName { get; set; }
        public Guid ColumnId { get; set; }
        public string SystemName { get; set; }
        public string AttType { get; set; }
        public string AttFieldName { get; set; }
        public string AttCaption { get; set; }
        public string AttName { get; set; }
        public string ColumnName { get; set; }
        public string ColumnArea { get; set; }
        public string SqluserName { get; set; }
        public bool? HasPermission { get; set; }
        public bool? Editable { get; set; }
    }
}
