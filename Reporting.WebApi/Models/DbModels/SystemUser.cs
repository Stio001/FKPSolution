using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemUser
    {
        public SystemUser()
        {
            ProjectUsers = new HashSet<ProjectUser>();
            SystemRoleUsers = new HashSet<SystemRoleUser>();
            SystemUserOrganizations = new HashSet<SystemUserOrganization>();
            SystemUserPermissionActionCatalogs = new HashSet<SystemUserPermissionActionCatalog>();
            SystemUserPermissionActions = new HashSet<SystemUserPermissionAction>();
            SystemUserPermissionColumns = new HashSet<SystemUserPermissionColumn>();
            SystemUserPermissionEntries = new HashSet<SystemUserPermissionEntry>();
            TaskStepUserFroms = new HashSet<TaskStep>();
            TaskStepUserTos = new HashSet<TaskStep>();
            UserVersions = new HashSet<UserVersion>();
        }

        public Guid Rid { get; set; }
        public string SqluserName { get; set; }
        public int SqluserId { get; set; }
        public string Description { get; set; }
        public Guid PersonId { get; set; }
        public bool? IsBlock { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? BlockDate { get; set; }

        public virtual AgentAgent Person { get; set; }
        public virtual ICollection<ProjectUser> ProjectUsers { get; set; }
        public virtual ICollection<SystemRoleUser> SystemRoleUsers { get; set; }
        public virtual ICollection<SystemUserOrganization> SystemUserOrganizations { get; set; }
        public virtual ICollection<SystemUserPermissionActionCatalog> SystemUserPermissionActionCatalogs { get; set; }
        public virtual ICollection<SystemUserPermissionAction> SystemUserPermissionActions { get; set; }
        public virtual ICollection<SystemUserPermissionColumn> SystemUserPermissionColumns { get; set; }
        public virtual ICollection<SystemUserPermissionEntry> SystemUserPermissionEntries { get; set; }
        public virtual ICollection<TaskStep> TaskStepUserFroms { get; set; }
        public virtual ICollection<TaskStep> TaskStepUserTos { get; set; }
        public virtual ICollection<UserVersion> UserVersions { get; set; }
    }
}
