using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class GlobalGlobalEntryAttr
    {
        public GlobalGlobalEntryAttr()
        {
            SystemRolePermissionActionCatalogs = new HashSet<SystemRolePermissionActionCatalog>();
            SystemRolePermissionActions = new HashSet<SystemRolePermissionAction>();
            SystemRolePermissionColumns = new HashSet<SystemRolePermissionColumn>();
            SystemUserPermissionActionCatalogs = new HashSet<SystemUserPermissionActionCatalog>();
            SystemUserPermissionActions = new HashSet<SystemUserPermissionAction>();
            SystemUserPermissionColumns = new HashSet<SystemUserPermissionColumn>();
            WorkParams = new HashSet<WorkParam>();
        }

        public Guid Rid { get; set; }
        public string AttName { get; set; }
        public string AttFieldName { get; set; }
        public string AttCaption { get; set; }
        public string AttType { get; set; }
        public string AttGroup { get; set; }
        public int? AttDomain { get; set; }
        public string AttDataType { get; set; }
        public Guid? ParentId { get; set; }

        public virtual GlobalGlobalEntry Parent { get; set; }
        public virtual ICollection<SystemRolePermissionActionCatalog> SystemRolePermissionActionCatalogs { get; set; }
        public virtual ICollection<SystemRolePermissionAction> SystemRolePermissionActions { get; set; }
        public virtual ICollection<SystemRolePermissionColumn> SystemRolePermissionColumns { get; set; }
        public virtual ICollection<SystemUserPermissionActionCatalog> SystemUserPermissionActionCatalogs { get; set; }
        public virtual ICollection<SystemUserPermissionAction> SystemUserPermissionActions { get; set; }
        public virtual ICollection<SystemUserPermissionColumn> SystemUserPermissionColumns { get; set; }
        public virtual ICollection<WorkParam> WorkParams { get; set; }
    }
}
