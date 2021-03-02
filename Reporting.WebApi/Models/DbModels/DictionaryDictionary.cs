using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryDictionary
    {
        public DictionaryDictionary()
        {
            AgentAgents = new HashSet<AgentAgent>();
            AgentContacts = new HashSet<AgentContact>();
            AgentPeople = new HashSet<AgentPerson>();
            DepartmentDepartments = new HashSet<DepartmentDepartment>();
            DictionaryPriorityCriteria = new HashSet<DictionaryPriorityCriterion>();
            DictionaryRisks = new HashSet<DictionaryRisk>();
            DictionaryStageTypeGosts = new HashSet<DictionaryStageType>();
            DictionaryStageTypeWorkKinds = new HashSet<DictionaryStageType>();
            DictionaryWorkCategories = new HashSet<DictionaryWork>();
            DictionaryWorkGosts = new HashSet<DictionaryWork>();
            DictionaryWorkKinds = new HashSet<DictionaryWork>();
            ExternalDocuments = new HashSet<ExternalDocument>();
            MessageMessages = new HashSet<MessageMessage>();
            PostPosts = new HashSet<PostPost>();
            ScenarioMessages = new HashSet<ScenarioMessage>();
            ScenarioScenarios = new HashSet<ScenarioScenario>();
            SpaceSystemSpaceSystems = new HashSet<SpaceSystemSpaceSystem>();
            SpacecraftSpacecrafts = new HashSet<SpacecraftSpacecraft>();
            StageStageGosts = new HashSet<StageStage>();
            StageStageKinds = new HashSet<StageStage>();
            StageStageWorkCategories = new HashSet<StageStage>();
            StructureElements = new HashSet<StructureElement>();
            TaskTasks = new HashSet<TaskTask>();
            VersionVersions = new HashSet<VersionVersion>();
            WorkWorkCategories = new HashSet<WorkWork>();
            WorkWorkTypes = new HashSet<WorkWork>();
        }

        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? OrderPlace { get; set; }
        public Guid EntryId { get; set; }
        public string Description { get; set; }

        public virtual GlobalGlobalEntry Entry { get; set; }
        public virtual ICollection<AgentAgent> AgentAgents { get; set; }
        public virtual ICollection<AgentContact> AgentContacts { get; set; }
        public virtual ICollection<AgentPerson> AgentPeople { get; set; }
        public virtual ICollection<DepartmentDepartment> DepartmentDepartments { get; set; }
        public virtual ICollection<DictionaryPriorityCriterion> DictionaryPriorityCriteria { get; set; }
        public virtual ICollection<DictionaryRisk> DictionaryRisks { get; set; }
        public virtual ICollection<DictionaryStageType> DictionaryStageTypeGosts { get; set; }
        public virtual ICollection<DictionaryStageType> DictionaryStageTypeWorkKinds { get; set; }
        public virtual ICollection<DictionaryWork> DictionaryWorkCategories { get; set; }
        public virtual ICollection<DictionaryWork> DictionaryWorkGosts { get; set; }
        public virtual ICollection<DictionaryWork> DictionaryWorkKinds { get; set; }
        public virtual ICollection<ExternalDocument> ExternalDocuments { get; set; }
        public virtual ICollection<MessageMessage> MessageMessages { get; set; }
        public virtual ICollection<PostPost> PostPosts { get; set; }
        public virtual ICollection<ScenarioMessage> ScenarioMessages { get; set; }
        public virtual ICollection<ScenarioScenario> ScenarioScenarios { get; set; }
        public virtual ICollection<SpaceSystemSpaceSystem> SpaceSystemSpaceSystems { get; set; }
        public virtual ICollection<SpacecraftSpacecraft> SpacecraftSpacecrafts { get; set; }
        public virtual ICollection<StageStage> StageStageGosts { get; set; }
        public virtual ICollection<StageStage> StageStageKinds { get; set; }
        public virtual ICollection<StageStage> StageStageWorkCategories { get; set; }
        public virtual ICollection<StructureElement> StructureElements { get; set; }
        public virtual ICollection<TaskTask> TaskTasks { get; set; }
        public virtual ICollection<VersionVersion> VersionVersions { get; set; }
        public virtual ICollection<WorkWork> WorkWorkCategories { get; set; }
        public virtual ICollection<WorkWork> WorkWorkTypes { get; set; }
    }
}
