using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemRolePermissionEntry
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public Guid EntryId { get; set; }
        public string EntryName { get; set; }
        public string SystemName { get; set; }
        public string ClassName { get; set; }
        public int HasPermission { get; set; }
    }
}
