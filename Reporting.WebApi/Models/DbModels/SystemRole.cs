using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemRole
    {
        public SystemRole()
        {
            StructureAgentGroups = new HashSet<StructureAgentGroup>();
            SystemRolePermissionActionCatalogs = new HashSet<SystemRolePermissionActionCatalog>();
            SystemRolePermissionActions = new HashSet<SystemRolePermissionAction>();
            SystemRolePermissionColumns = new HashSet<SystemRolePermissionColumn>();
            SystemRolePermissionEntries = new HashSet<SystemRolePermissionEntry>();
            SystemRoleUsers = new HashSet<SystemRoleUser>();
            TaskSteps = new HashSet<TaskStep>();
            UserReportRoles = new HashSet<UserReportRole>();
        }

        public Guid Rid { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual ICollection<StructureAgentGroup> StructureAgentGroups { get; set; }
        public virtual ICollection<SystemRolePermissionActionCatalog> SystemRolePermissionActionCatalogs { get; set; }
        public virtual ICollection<SystemRolePermissionAction> SystemRolePermissionActions { get; set; }
        public virtual ICollection<SystemRolePermissionColumn> SystemRolePermissionColumns { get; set; }
        public virtual ICollection<SystemRolePermissionEntry> SystemRolePermissionEntries { get; set; }
        public virtual ICollection<SystemRoleUser> SystemRoleUsers { get; set; }
        public virtual ICollection<TaskStep> TaskSteps { get; set; }
        public virtual ICollection<UserReportRole> UserReportRoles { get; set; }
    }
}
