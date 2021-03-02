using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemRolePermissionAction
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public Guid ActionId { get; set; }
        public string ActionName { get; set; }
        public string ActionArea { get; set; }
        public bool? HasPermission { get; set; }
        public bool? Audit { get; set; }
        public int Idx { get; set; }
        public int IdxGr { get; set; }
        public string AttName { get; set; }
        public string SqluserName { get; set; }
        public string SystemName { get; set; }
    }
}
