using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class AgentAgent
    {
        public AgentAgent()
        {
            AgentContacts = new HashSet<AgentContact>();
            AgentGroupAgents = new HashSet<AgentGroupAgent>();
            AgentPeople = new HashSet<AgentPerson>();
            DocumentExportHistoryAgentFroms = new HashSet<DocumentExportHistory>();
            DocumentExportHistoryAgentTos = new HashSet<DocumentExportHistory>();
            ExternalDocuments = new HashSet<ExternalDocument>();
            HistoryStates = new HashSet<HistoryState>();
            Organizations = new HashSet<Organization>();
            ScenarioStages = new HashSet<ScenarioStage>();
            SystemUsers = new HashSet<SystemUser>();
            TaskTaskCustomers = new HashSet<TaskTask>();
            TaskTaskSeniorWorksNavigations = new HashSet<TaskTask>();
            WorkAgents = new HashSet<WorkAgent>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public string Cpp { get; set; }
        public string Okpo { get; set; }
        public string Ogrn { get; set; }
        public Guid CatalogId { get; set; }
        public string Note { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int AgentType { get; set; }
        public DateTime? DateR { get; set; }
        public string Address { get; set; }
        public string AddName { get; set; }
        public Guid? AgentCategory { get; set; }

        public virtual DictionaryDictionary AgentCategoryNavigation { get; set; }
        public virtual CatalogCatalog Catalog { get; set; }
        public virtual ICollection<AgentContact> AgentContacts { get; set; }
        public virtual ICollection<AgentGroupAgent> AgentGroupAgents { get; set; }
        public virtual ICollection<AgentPerson> AgentPeople { get; set; }
        public virtual ICollection<DocumentExportHistory> DocumentExportHistoryAgentFroms { get; set; }
        public virtual ICollection<DocumentExportHistory> DocumentExportHistoryAgentTos { get; set; }
        public virtual ICollection<ExternalDocument> ExternalDocuments { get; set; }
        public virtual ICollection<HistoryState> HistoryStates { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }
        public virtual ICollection<ScenarioStage> ScenarioStages { get; set; }
        public virtual ICollection<SystemUser> SystemUsers { get; set; }
        public virtual ICollection<TaskTask> TaskTaskCustomers { get; set; }
        public virtual ICollection<TaskTask> TaskTaskSeniorWorksNavigations { get; set; }
        public virtual ICollection<WorkAgent> WorkAgents { get; set; }
    }
}
