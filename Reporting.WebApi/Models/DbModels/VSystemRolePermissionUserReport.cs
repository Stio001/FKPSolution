using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemRolePermissionUserReport
    {
        public Guid? ReportId { get; set; }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public int SqluserId { get; set; }
        public string SqluserName { get; set; }
        public bool? IsBlock { get; set; }
    }
}
