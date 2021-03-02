using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VersionVersion
    {
        public VersionVersion()
        {
            DictionaryLinks = new HashSet<DictionaryLink>();
            DictionaryTargetIndicators = new HashSet<DictionaryTargetIndicator>();
            DictionaryWorkEvents = new HashSet<DictionaryWorkEvent>();
            DictionaryWorkParams = new HashSet<DictionaryWorkParam>();
            DictionaryWorkRiskEvents = new HashSet<DictionaryWorkRiskEvent>();
            EconomicEffects = new HashSet<EconomicEffect>();
            InverseParent = new HashSet<VersionVersion>();
            ObjectiveObjectives = new HashSet<ObjectiveObjective>();
            OrbitalGroupVariants = new HashSet<OrbitalGroupVariant>();
            ParamValues = new HashSet<ParamValue>();
            PriorityCriterionObjects = new HashSet<PriorityCriterionObject>();
            PriorityCriterionRanks = new HashSet<PriorityCriterionRank>();
            ProjectPlanFinDistributions = new HashSet<ProjectPlanFinDistribution>();
            ProjectProjects = new HashSet<ProjectProject>();
            PurposePurposes = new HashSet<PurposePurpose>();
            RiskEvents = new HashSet<RiskEvent>();
            RiskPriorities = new HashSet<RiskPriority>();
            SpacePolicyObjectiveDirections = new HashSet<SpacePolicyObjectiveDirection>();
            SpacecraftSpacecrafts = new HashSet<SpacecraftSpacecraft>();
            StageStages = new HashSet<StageStage>();
            StructureParams = new HashSet<StructureParam>();
            StructureStructures = new HashSet<StructureStructure>();
            TaskResultValues = new HashSet<TaskResultValue>();
            TaskTasks = new HashSet<TaskTask>();
            TechnicParams = new HashSet<TechnicParam>();
            TechnicStatuses = new HashSet<TechnicStatus>();
            TechnicTypeParams = new HashSet<TechnicTypeParam>();
            UserVersions = new HashSet<UserVersion>();
            WorkAgents = new HashSet<WorkAgent>();
            WorkDirectionParams = new HashSet<WorkDirectionParam>();
            WorkParams = new HashSet<WorkParam>();
            WorkWorks = new HashSet<WorkWork>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Note { get; set; }
        public DateTime? StateDate { get; set; }
        public string Num { get; set; }
        public int StateId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? TypeId { get; set; }
        public DateTime? AcceptDate { get; set; }
        public bool? IsRemoved { get; set; }
        public Guid? VersionFromId { get; set; }
        public string CreateInfo { get; set; }
        public bool? UseInGraph { get; set; }
        public string ValidDocNum { get; set; }
        public DateTime? ValidDocDate { get; set; }

        public virtual VersionVersion Parent { get; set; }
        public virtual DictionaryDictionary Type { get; set; }
        public virtual ICollection<DictionaryLink> DictionaryLinks { get; set; }
        public virtual ICollection<DictionaryTargetIndicator> DictionaryTargetIndicators { get; set; }
        public virtual ICollection<DictionaryWorkEvent> DictionaryWorkEvents { get; set; }
        public virtual ICollection<DictionaryWorkParam> DictionaryWorkParams { get; set; }
        public virtual ICollection<DictionaryWorkRiskEvent> DictionaryWorkRiskEvents { get; set; }
        public virtual ICollection<EconomicEffect> EconomicEffects { get; set; }
        public virtual ICollection<VersionVersion> InverseParent { get; set; }
        public virtual ICollection<ObjectiveObjective> ObjectiveObjectives { get; set; }
        public virtual ICollection<OrbitalGroupVariant> OrbitalGroupVariants { get; set; }
        public virtual ICollection<ParamValue> ParamValues { get; set; }
        public virtual ICollection<PriorityCriterionObject> PriorityCriterionObjects { get; set; }
        public virtual ICollection<PriorityCriterionRank> PriorityCriterionRanks { get; set; }
        public virtual ICollection<ProjectPlanFinDistribution> ProjectPlanFinDistributions { get; set; }
        public virtual ICollection<ProjectProject> ProjectProjects { get; set; }
        public virtual ICollection<PurposePurpose> PurposePurposes { get; set; }
        public virtual ICollection<RiskEvent> RiskEvents { get; set; }
        public virtual ICollection<RiskPriority> RiskPriorities { get; set; }
        public virtual ICollection<SpacePolicyObjectiveDirection> SpacePolicyObjectiveDirections { get; set; }
        public virtual ICollection<SpacecraftSpacecraft> SpacecraftSpacecrafts { get; set; }
        public virtual ICollection<StageStage> StageStages { get; set; }
        public virtual ICollection<StructureParam> StructureParams { get; set; }
        public virtual ICollection<StructureStructure> StructureStructures { get; set; }
        public virtual ICollection<TaskResultValue> TaskResultValues { get; set; }
        public virtual ICollection<TaskTask> TaskTasks { get; set; }
        public virtual ICollection<TechnicParam> TechnicParams { get; set; }
        public virtual ICollection<TechnicStatus> TechnicStatuses { get; set; }
        public virtual ICollection<TechnicTypeParam> TechnicTypeParams { get; set; }
        public virtual ICollection<UserVersion> UserVersions { get; set; }
        public virtual ICollection<WorkAgent> WorkAgents { get; set; }
        public virtual ICollection<WorkDirectionParam> WorkDirectionParams { get; set; }
        public virtual ICollection<WorkParam> WorkParams { get; set; }
        public virtual ICollection<WorkWork> WorkWorks { get; set; }
    }
}
