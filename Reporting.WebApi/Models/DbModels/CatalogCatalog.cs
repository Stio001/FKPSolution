using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class CatalogCatalog
    {
        public CatalogCatalog()
        {
            AgentAgents = new HashSet<AgentAgent>();
            AgentGroupGroups = new HashSet<AgentGroupGroup>();
            AgentPeople = new HashSet<AgentPerson>();
            DictionaryLinks = new HashSet<DictionaryLink>();
            DictionaryMeasures = new HashSet<DictionaryMeasure>();
            DictionaryRisks = new HashSet<DictionaryRisk>();
            DictionaryTechnics = new HashSet<DictionaryTechnic>();
            DictionaryWorks = new HashSet<DictionaryWork>();
            ExternalDocuments = new HashSet<ExternalDocument>();
            GroupParamGroups = new HashSet<GroupParamGroup>();
            GroupWorkGroups = new HashSet<GroupWorkGroup>();
            InverseParent = new HashSet<CatalogCatalog>();
            MessageMessages = new HashSet<MessageMessage>();
            MmWorkGroups = new HashSet<MmWorkGroup>();
            MmWorks = new HashSet<MmWork>();
            ParamParams = new HashSet<ParamParam>();
            PostPosts = new HashSet<PostPost>();
            RiskEvents = new HashSet<RiskEvent>();
            ScenarioScenarios = new HashSet<ScenarioScenario>();
            SpaceLaunchSets = new HashSet<SpaceLaunchSet>();
            SystemIssues = new HashSet<SystemIssue>();
            SystemRolePermissionActionCatalogs = new HashSet<SystemRolePermissionActionCatalog>();
            SystemUserPermissionActionCatalogs = new HashSet<SystemUserPermissionActionCatalog>();
            UserApplicationApplications = new HashSet<UserApplicationApplication>();
            UserGraphGraphs = new HashSet<UserGraphGraph>();
            UserProcedureProcedures = new HashSet<UserProcedureProcedure>();
            UserReportReports = new HashSet<UserReportReport>();
            UserUsers = new HashSet<UserUser>();
            WorkCodes = new HashSet<WorkCode>();
            WorkStages = new HashSet<WorkStage>();
        }

        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid EntryId { get; set; }

        public virtual GlobalGlobalEntry Entry { get; set; }
        public virtual CatalogCatalog Parent { get; set; }
        public virtual ICollection<AgentAgent> AgentAgents { get; set; }
        public virtual ICollection<AgentGroupGroup> AgentGroupGroups { get; set; }
        public virtual ICollection<AgentPerson> AgentPeople { get; set; }
        public virtual ICollection<DictionaryLink> DictionaryLinks { get; set; }
        public virtual ICollection<DictionaryMeasure> DictionaryMeasures { get; set; }
        public virtual ICollection<DictionaryRisk> DictionaryRisks { get; set; }
        public virtual ICollection<DictionaryTechnic> DictionaryTechnics { get; set; }
        public virtual ICollection<DictionaryWork> DictionaryWorks { get; set; }
        public virtual ICollection<ExternalDocument> ExternalDocuments { get; set; }
        public virtual ICollection<GroupParamGroup> GroupParamGroups { get; set; }
        public virtual ICollection<GroupWorkGroup> GroupWorkGroups { get; set; }
        public virtual ICollection<CatalogCatalog> InverseParent { get; set; }
        public virtual ICollection<MessageMessage> MessageMessages { get; set; }
        public virtual ICollection<MmWorkGroup> MmWorkGroups { get; set; }
        public virtual ICollection<MmWork> MmWorks { get; set; }
        public virtual ICollection<ParamParam> ParamParams { get; set; }
        public virtual ICollection<PostPost> PostPosts { get; set; }
        public virtual ICollection<RiskEvent> RiskEvents { get; set; }
        public virtual ICollection<ScenarioScenario> ScenarioScenarios { get; set; }
        public virtual ICollection<SpaceLaunchSet> SpaceLaunchSets { get; set; }
        public virtual ICollection<SystemIssue> SystemIssues { get; set; }
        public virtual ICollection<SystemRolePermissionActionCatalog> SystemRolePermissionActionCatalogs { get; set; }
        public virtual ICollection<SystemUserPermissionActionCatalog> SystemUserPermissionActionCatalogs { get; set; }
        public virtual ICollection<UserApplicationApplication> UserApplicationApplications { get; set; }
        public virtual ICollection<UserGraphGraph> UserGraphGraphs { get; set; }
        public virtual ICollection<UserProcedureProcedure> UserProcedureProcedures { get; set; }
        public virtual ICollection<UserReportReport> UserReportReports { get; set; }
        public virtual ICollection<UserUser> UserUsers { get; set; }
        public virtual ICollection<WorkCode> WorkCodes { get; set; }
        public virtual ICollection<WorkStage> WorkStages { get; set; }
    }
}
