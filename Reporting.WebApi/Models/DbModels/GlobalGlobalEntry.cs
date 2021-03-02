using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class GlobalGlobalEntry
    {
        public GlobalGlobalEntry()
        {
            CatalogCatalogs = new HashSet<CatalogCatalog>();
            DictionaryDictionaries = new HashSet<DictionaryDictionary>();
            DictionaryTechnics = new HashSet<DictionaryTechnic>();
            DocumentRelationEntryIdinNavigations = new HashSet<DocumentRelation>();
            DocumentRelationEntryIdoutNavigations = new HashSet<DocumentRelation>();
            GlobalGlobalEntryAttrs = new HashSet<GlobalGlobalEntryAttr>();
            GlobalGlobalEntryDetails = new HashSet<GlobalGlobalEntryDetail>();
            SystemIssues = new HashSet<SystemIssue>();
            SystemRolePermissionEntries = new HashSet<SystemRolePermissionEntry>();
            SystemUserPermissionEntries = new HashSet<SystemUserPermissionEntry>();
            TechnicStatuses = new HashSet<TechnicStatus>();
            TechnicTypes = new HashSet<TechnicType>();
            UserReportSections = new HashSet<UserReportSection>();
            WorkParams = new HashSet<WorkParam>();
            WorkWorks = new HashSet<WorkWork>();
        }

        public Guid Rid { get; set; }
        public string SystemName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsRelation { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsOnlyChildUse { get; set; }
        public string ClassName { get; set; }
        public string ClassLib { get; set; }
        public string EditClassName { get; set; }

        public virtual ICollection<CatalogCatalog> CatalogCatalogs { get; set; }
        public virtual ICollection<DictionaryDictionary> DictionaryDictionaries { get; set; }
        public virtual ICollection<DictionaryTechnic> DictionaryTechnics { get; set; }
        public virtual ICollection<DocumentRelation> DocumentRelationEntryIdinNavigations { get; set; }
        public virtual ICollection<DocumentRelation> DocumentRelationEntryIdoutNavigations { get; set; }
        public virtual ICollection<GlobalGlobalEntryAttr> GlobalGlobalEntryAttrs { get; set; }
        public virtual ICollection<GlobalGlobalEntryDetail> GlobalGlobalEntryDetails { get; set; }
        public virtual ICollection<SystemIssue> SystemIssues { get; set; }
        public virtual ICollection<SystemRolePermissionEntry> SystemRolePermissionEntries { get; set; }
        public virtual ICollection<SystemUserPermissionEntry> SystemUserPermissionEntries { get; set; }
        public virtual ICollection<TechnicStatus> TechnicStatuses { get; set; }
        public virtual ICollection<TechnicType> TechnicTypes { get; set; }
        public virtual ICollection<UserReportSection> UserReportSections { get; set; }
        public virtual ICollection<WorkParam> WorkParams { get; set; }
        public virtual ICollection<WorkWork> WorkWorks { get; set; }
    }
}
