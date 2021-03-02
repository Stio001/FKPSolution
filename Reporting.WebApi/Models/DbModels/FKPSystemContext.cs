using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class FKPSystemContext : DbContext
    {
        public FKPSystemContext()
        {
        }

        public FKPSystemContext(DbContextOptions<FKPSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AgentAgent> AgentAgents { get; set; }
        public virtual DbSet<AgentContact> AgentContacts { get; set; }
        public virtual DbSet<AgentGroupAgent> AgentGroupAgents { get; set; }
        public virtual DbSet<AgentGroupGroup> AgentGroupGroups { get; set; }
        public virtual DbSet<AgentPerson> AgentPeople { get; set; }
        public virtual DbSet<CatalogCatalog> CatalogCatalogs { get; set; }
        public virtual DbSet<DashboardFilter> DashboardFilters { get; set; }
        public virtual DbSet<DepartmentDepartment> DepartmentDepartments { get; set; }
        public virtual DbSet<DictionaryDictionary> DictionaryDictionaries { get; set; }
        public virtual DbSet<DictionaryEventType> DictionaryEventTypes { get; set; }
        public virtual DbSet<DictionaryLink> DictionaryLinks { get; set; }
        public virtual DbSet<DictionaryMeasure> DictionaryMeasures { get; set; }
        public virtual DbSet<DictionaryPriorityCriterion> DictionaryPriorityCriteria { get; set; }
        public virtual DbSet<DictionaryRisk> DictionaryRisks { get; set; }
        public virtual DbSet<DictionaryStageType> DictionaryStageTypes { get; set; }
        public virtual DbSet<DictionaryTargetIndicator> DictionaryTargetIndicators { get; set; }
        public virtual DbSet<DictionaryTechnic> DictionaryTechnics { get; set; }
        public virtual DbSet<DictionaryTechnicAnalog> DictionaryTechnicAnalogs { get; set; }
        public virtual DbSet<DictionaryTechnologyReadyLevel> DictionaryTechnologyReadyLevels { get; set; }
        public virtual DbSet<DictionaryWork> DictionaryWorks { get; set; }
        public virtual DbSet<DictionaryWorkEvent> DictionaryWorkEvents { get; set; }
        public virtual DbSet<DictionaryWorkEventFin> DictionaryWorkEventFins { get; set; }
        public virtual DbSet<DictionaryWorkEventTechnic> DictionaryWorkEventTechnics { get; set; }
        public virtual DbSet<DictionaryWorkEventUndo> DictionaryWorkEventUndos { get; set; }
        public virtual DbSet<DictionaryWorkParam> DictionaryWorkParams { get; set; }
        public virtual DbSet<DictionaryWorkRiskEvent> DictionaryWorkRiskEvents { get; set; }
        public virtual DbSet<DocumentExportHistory> DocumentExportHistories { get; set; }
        public virtual DbSet<DocumentRelation> DocumentRelations { get; set; }
        public virtual DbSet<EconomicEffect> EconomicEffects { get; set; }
        public virtual DbSet<EconomicEffectProject> EconomicEffectProjects { get; set; }
        public virtual DbSet<EventMessage> EventMessages { get; set; }
        public virtual DbSet<ExternalDocument> ExternalDocuments { get; set; }
        public virtual DbSet<ExternalFile> ExternalFiles { get; set; }
        public virtual DbSet<FinanceLimit> FinanceLimits { get; set; }
        public virtual DbSet<FinanceLimitSpec> FinanceLimitSpecs { get; set; }
        public virtual DbSet<FinanceWorkPlaceDataHistory> FinanceWorkPlaceDataHistories { get; set; }
        public virtual DbSet<FinanceWorkPlaceDataUndo> FinanceWorkPlaceDataUndos { get; set; }
        public virtual DbSet<FinanceWorkPlaceDatum> FinanceWorkPlaceData { get; set; }
        public virtual DbSet<GlobalGlobalEntry> GlobalGlobalEntries { get; set; }
        public virtual DbSet<GlobalGlobalEntryAttr> GlobalGlobalEntryAttrs { get; set; }
        public virtual DbSet<GlobalGlobalEntryDetail> GlobalGlobalEntryDetails { get; set; }
        public virtual DbSet<GlobalUserDictionary> GlobalUserDictionaries { get; set; }
        public virtual DbSet<GroupParamGroup> GroupParamGroups { get; set; }
        public virtual DbSet<GroupParamParam> GroupParamParams { get; set; }
        public virtual DbSet<GroupWorkGroup> GroupWorkGroups { get; set; }
        public virtual DbSet<GroupWorkWork> GroupWorkWorks { get; set; }
        public virtual DbSet<HistoryState> HistoryStates { get; set; }
        public virtual DbSet<IntObligationIntObligation> IntObligationIntObligations { get; set; }
        public virtual DbSet<MessageMessage> MessageMessages { get; set; }
        public virtual DbSet<MmWork> MmWorks { get; set; }
        public virtual DbSet<MmWorkGroup> MmWorkGroups { get; set; }
        public virtual DbSet<MmWorkGroupPerson> MmWorkGroupPeople { get; set; }
        public virtual DbSet<MmWorkPerson> MmWorkPeople { get; set; }
        public virtual DbSet<MmWorkPersonContribution> MmWorkPersonContributions { get; set; }
        public virtual DbSet<MmWorkPersonParam> MmWorkPersonParams { get; set; }
        public virtual DbSet<MmWorkStage> MmWorkStages { get; set; }
        public virtual DbSet<ObjectiveObjective> ObjectiveObjectives { get; set; }
        public virtual DbSet<OrbitalGroupVariant> OrbitalGroupVariants { get; set; }
        public virtual DbSet<OrbitalGroupVariantDatum> OrbitalGroupVariantData { get; set; }
        public virtual DbSet<OrbitalGroupVariantPlan> OrbitalGroupVariantPlans { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<ParamParam> ParamParams { get; set; }
        public virtual DbSet<ParamValue> ParamValues { get; set; }
        public virtual DbSet<ParamValueResult> ParamValueResults { get; set; }
        public virtual DbSet<PostDuty> PostDuties { get; set; }
        public virtual DbSet<PostPost> PostPosts { get; set; }
        public virtual DbSet<PriorityCriterionObject> PriorityCriterionObjects { get; set; }
        public virtual DbSet<PriorityCriterionRank> PriorityCriterionRanks { get; set; }
        public virtual DbSet<PriorityCriterionScale> PriorityCriterionScales { get; set; }
        public virtual DbSet<PriorityCriterionValue> PriorityCriterionValues { get; set; }
        public virtual DbSet<ProjectPlanFinDistribution> ProjectPlanFinDistributions { get; set; }
        public virtual DbSet<ProjectProject> ProjectProjects { get; set; }
        public virtual DbSet<ProjectUser> ProjectUsers { get; set; }
        public virtual DbSet<PurposePurpose> PurposePurposes { get; set; }
        public virtual DbSet<RiskDamageValue> RiskDamageValues { get; set; }
        public virtual DbSet<RiskEvent> RiskEvents { get; set; }
        public virtual DbSet<RiskEventProbabilityValue> RiskEventProbabilityValues { get; set; }
        public virtual DbSet<RiskEventValue> RiskEventValues { get; set; }
        public virtual DbSet<RiskPriority> RiskPriorities { get; set; }
        public virtual DbSet<ScenarioHistory> ScenarioHistories { get; set; }
        public virtual DbSet<ScenarioMessage> ScenarioMessages { get; set; }
        public virtual DbSet<ScenarioScenario> ScenarioScenarios { get; set; }
        public virtual DbSet<ScenarioStage> ScenarioStages { get; set; }
        public virtual DbSet<SchedulerAppointment> SchedulerAppointments { get; set; }
        public virtual DbSet<SchedulerDependency> SchedulerDependencies { get; set; }
        public virtual DbSet<SelectList> SelectLists { get; set; }
        public virtual DbSet<SpaceLaunchSet> SpaceLaunchSets { get; set; }
        public virtual DbSet<SpaceLaunchSetSpec> SpaceLaunchSetSpecs { get; set; }
        public virtual DbSet<SpacePolicyObjective> SpacePolicyObjectives { get; set; }
        public virtual DbSet<SpacePolicyObjectiveDirection> SpacePolicyObjectiveDirections { get; set; }
        public virtual DbSet<SpacePolicyObjectiveObjective> SpacePolicyObjectiveObjectives { get; set; }
        public virtual DbSet<SpaceSystemSpaceSystem> SpaceSystemSpaceSystems { get; set; }
        public virtual DbSet<SpacecraftSpacecraft> SpacecraftSpacecrafts { get; set; }
        public virtual DbSet<SpaceportCoordinate> SpaceportCoordinates { get; set; }
        public virtual DbSet<StageStage> StageStages { get; set; }
        public virtual DbSet<StructureAgentGroup> StructureAgentGroups { get; set; }
        public virtual DbSet<StructureElement> StructureElements { get; set; }
        public virtual DbSet<StructureParam> StructureParams { get; set; }
        public virtual DbSet<StructureStructure> StructureStructures { get; set; }
        public virtual DbSet<StructureStructureGetWorkGanttDependenceTemp> StructureStructureGetWorkGanttDependenceTemps { get; set; }
        public virtual DbSet<StructureStructureGetWorkGanttResourceTemp> StructureStructureGetWorkGanttResourceTemps { get; set; }
        public virtual DbSet<StructureStructureGetWorkGanttSession> StructureStructureGetWorkGanttSessions { get; set; }
        public virtual DbSet<StructureStructureGetWorkGanttTemp> StructureStructureGetWorkGanttTemps { get; set; }
        public virtual DbSet<SystemAdminUpdateInfo> SystemAdminUpdateInfos { get; set; }
        public virtual DbSet<SystemAdminUpdateInfoSpec> SystemAdminUpdateInfoSpecs { get; set; }
        public virtual DbSet<SystemAlert> SystemAlerts { get; set; }
        public virtual DbSet<SystemAudit> SystemAudits { get; set; }
        public virtual DbSet<SystemAuditLog> SystemAuditLogs { get; set; }
        public virtual DbSet<SystemBackup> SystemBackups { get; set; }
        public virtual DbSet<SystemCopyHelper> SystemCopyHelpers { get; set; }
        public virtual DbSet<SystemErrorLog> SystemErrorLogs { get; set; }
        public virtual DbSet<SystemIssue> SystemIssues { get; set; }
        public virtual DbSet<SystemIssueHistory> SystemIssueHistories { get; set; }
        public virtual DbSet<SystemLicense> SystemLicenses { get; set; }
        public virtual DbSet<SystemRole> SystemRoles { get; set; }
        public virtual DbSet<SystemRolePermissionAction> SystemRolePermissionActions { get; set; }
        public virtual DbSet<SystemRolePermissionActionCatalog> SystemRolePermissionActionCatalogs { get; set; }
        public virtual DbSet<SystemRolePermissionColumn> SystemRolePermissionColumns { get; set; }
        public virtual DbSet<SystemRolePermissionEntry> SystemRolePermissionEntries { get; set; }
        public virtual DbSet<SystemRoleUser> SystemRoleUsers { get; set; }
        public virtual DbSet<SystemSession> SystemSessions { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }
        public virtual DbSet<SystemUpdateApp> SystemUpdateApps { get; set; }
        public virtual DbSet<SystemUpdateAppLog> SystemUpdateAppLogs { get; set; }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }
        public virtual DbSet<SystemUserOrganization> SystemUserOrganizations { get; set; }
        public virtual DbSet<SystemUserPermissionAction> SystemUserPermissionActions { get; set; }
        public virtual DbSet<SystemUserPermissionActionCatalog> SystemUserPermissionActionCatalogs { get; set; }
        public virtual DbSet<SystemUserPermissionColumn> SystemUserPermissionColumns { get; set; }
        public virtual DbSet<SystemUserPermissionEntry> SystemUserPermissionEntries { get; set; }
        public virtual DbSet<TargetIndicator03T01Value> TargetIndicator03T01Values { get; set; }
        public virtual DbSet<TargetIndicatorProject> TargetIndicatorProjects { get; set; }
        public virtual DbSet<TargetIndicatorValue> TargetIndicatorValues { get; set; }
        public virtual DbSet<TaskElement> TaskElements { get; set; }
        public virtual DbSet<TaskHistory> TaskHistories { get; set; }
        public virtual DbSet<TaskResultValue> TaskResultValues { get; set; }
        public virtual DbSet<TaskStep> TaskSteps { get; set; }
        public virtual DbSet<TaskStepElement> TaskStepElements { get; set; }
        public virtual DbSet<TaskTask> TaskTasks { get; set; }
        public virtual DbSet<TechnicCompatibility> TechnicCompatibilities { get; set; }
        public virtual DbSet<TechnicParam> TechnicParams { get; set; }
        public virtual DbSet<TechnicStatus> TechnicStatuses { get; set; }
        public virtual DbSet<TechnicType> TechnicTypes { get; set; }
        public virtual DbSet<TechnicTypeAnalog> TechnicTypeAnalogs { get; set; }
        public virtual DbSet<TechnicTypeParam> TechnicTypeParams { get; set; }
        public virtual DbSet<TmpParamValue> TmpParamValues { get; set; }
        public virtual DbSet<TmpParamValueR> TmpParamValueRs { get; set; }
        public virtual DbSet<TmpRiscFactorCombination> TmpRiscFactorCombinations { get; set; }
        public virtual DbSet<TmpStrCopy> TmpStrCopies { get; set; }
        public virtual DbSet<UserApplicationApplication> UserApplicationApplications { get; set; }
        public virtual DbSet<UserArpParam> UserArpParams { get; set; }
        public virtual DbSet<UserArpSection> UserArpSections { get; set; }
        public virtual DbSet<UserGraphGraph> UserGraphGraphs { get; set; }
        public virtual DbSet<UserProcedureProcedure> UserProcedureProcedures { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<UserReportReport> UserReportReports { get; set; }
        public virtual DbSet<UserReportRole> UserReportRoles { get; set; }
        public virtual DbSet<UserReportSection> UserReportSections { get; set; }
        public virtual DbSet<UserUser> UserUsers { get; set; }
        public virtual DbSet<UserVersion> UserVersions { get; set; }
        public virtual DbSet<VAgentAgent> VAgentAgents { get; set; }
        public virtual DbSet<VAgentContact> VAgentContacts { get; set; }
        public virtual DbSet<VAgentGroupAgent> VAgentGroupAgents { get; set; }
        public virtual DbSet<VAgentGroupGroup> VAgentGroupGroups { get; set; }
        public virtual DbSet<VAgentPerson> VAgentPeople { get; set; }
        public virtual DbSet<VCatalogCatalog> VCatalogCatalogs { get; set; }
        public virtual DbSet<VDashBoardDashBoard> VDashBoardDashBoards { get; set; }
        public virtual DbSet<VDashboardFilter> VDashboardFilters { get; set; }
        public virtual DbSet<VDepartmentDepartment> VDepartmentDepartments { get; set; }
        public virtual DbSet<VDictionaryDictionary> VDictionaryDictionaries { get; set; }
        public virtual DbSet<VDictionaryEventType> VDictionaryEventTypes { get; set; }
        public virtual DbSet<VDictionaryLink> VDictionaryLinks { get; set; }
        public virtual DbSet<VDictionaryLinkElement> VDictionaryLinkElements { get; set; }
        public virtual DbSet<VDictionaryMeasure> VDictionaryMeasures { get; set; }
        public virtual DbSet<VDictionaryPriorityCriterion> VDictionaryPriorityCriteria { get; set; }
        public virtual DbSet<VDictionaryPriorityCriterionKind> VDictionaryPriorityCriterionKinds { get; set; }
        public virtual DbSet<VDictionaryPriorityCriterionKindSpec> VDictionaryPriorityCriterionKindSpecs { get; set; }
        public virtual DbSet<VDictionaryPriorityCriterionList> VDictionaryPriorityCriterionLists { get; set; }
        public virtual DbSet<VDictionaryProjectWork> VDictionaryProjectWorks { get; set; }
        public virtual DbSet<VDictionaryRisk> VDictionaryRisks { get; set; }
        public virtual DbSet<VDictionaryRiskObject> VDictionaryRiskObjects { get; set; }
        public virtual DbSet<VDictionaryStageType> VDictionaryStageTypes { get; set; }
        public virtual DbSet<VDictionaryTargetIndicator> VDictionaryTargetIndicators { get; set; }
        public virtual DbSet<VDictionaryTargetIndicatorEtalon> VDictionaryTargetIndicatorEtalons { get; set; }
        public virtual DbSet<VDictionaryTargetIndicatorMethod> VDictionaryTargetIndicatorMethods { get; set; }
        public virtual DbSet<VDictionaryTargetIndicatorPriority> VDictionaryTargetIndicatorPriorities { get; set; }
        public virtual DbSet<VDictionaryTechnic> VDictionaryTechnics { get; set; }
        public virtual DbSet<VDictionaryTechnicKa> VDictionaryTechnicKas { get; set; }
        public virtual DbSet<VDictionaryTechnicKaAnalog> VDictionaryTechnicKaAnalogs { get; set; }
        public virtual DbSet<VDictionaryTechnicKaLight> VDictionaryTechnicKaLights { get; set; }
        public virtual DbSet<VDictionaryTechnicOb> VDictionaryTechnicObs { get; set; }
        public virtual DbSet<VDictionaryTechnicOb1> VDictionaryTechnicOb1s { get; set; }
        public virtual DbSet<VDictionaryTechnicOther> VDictionaryTechnicOthers { get; set; }
        public virtual DbSet<VDictionaryTechnicRb> VDictionaryTechnicRbs { get; set; }
        public virtual DbSet<VDictionaryTechnicRb1> VDictionaryTechnicRb1s { get; set; }
        public virtual DbSet<VDictionaryTechnicRn> VDictionaryTechnicRns { get; set; }
        public virtual DbSet<VDictionaryTechnicRn1> VDictionaryTechnicRn1s { get; set; }
        public virtual DbSet<VDictionaryTechnologyReadyLevel> VDictionaryTechnologyReadyLevels { get; set; }
        public virtual DbSet<VDictionaryWork> VDictionaryWorks { get; set; }
        public virtual DbSet<VDictionaryWorkCompareVersion> VDictionaryWorkCompareVersions { get; set; }
        public virtual DbSet<VDictionaryWorkDurationOkr> VDictionaryWorkDurationOkrs { get; set; }
        public virtual DbSet<VDictionaryWorkEvent> VDictionaryWorkEvents { get; set; }
        public virtual DbSet<VDictionaryWorkEventDistSum> VDictionaryWorkEventDistSums { get; set; }
        public virtual DbSet<VDictionaryWorkEventFin> VDictionaryWorkEventFins { get; set; }
        public virtual DbSet<VDictionaryWorkEventFinPivot> VDictionaryWorkEventFinPivots { get; set; }
        public virtual DbSet<VDictionaryWorkEventFinWork> VDictionaryWorkEventFinWorks { get; set; }
        public virtual DbSet<VDictionaryWorkEventLight> VDictionaryWorkEventLights { get; set; }
        public virtual DbSet<VDictionaryWorkEventResult> VDictionaryWorkEventResults { get; set; }
        public virtual DbSet<VDictionaryWorkEventRp> VDictionaryWorkEventRps { get; set; }
        public virtual DbSet<VDictionaryWorkEventSum> VDictionaryWorkEventSums { get; set; }
        public virtual DbSet<VDictionaryWorkEventTechnic> VDictionaryWorkEventTechnics { get; set; }
        public virtual DbSet<VDictionaryWorkEventUndo> VDictionaryWorkEventUndos { get; set; }
        public virtual DbSet<VDictionaryWorkFinInfo> VDictionaryWorkFinInfos { get; set; }
        public virtual DbSet<VDictionaryWorkFinPivot> VDictionaryWorkFinPivots { get; set; }
        public virtual DbSet<VDictionaryWorkLight> VDictionaryWorkLights { get; set; }
        public virtual DbSet<VDictionaryWorkOlap> VDictionaryWorkOlaps { get; set; }
        public virtual DbSet<VDictionaryWorkParam> VDictionaryWorkParams { get; set; }
        public virtual DbSet<VDictionaryWorkProject> VDictionaryWorkProjects { get; set; }
        public virtual DbSet<VDictionaryWorkRelation> VDictionaryWorkRelations { get; set; }
        public virtual DbSet<VDictionaryWorkRiskEvent> VDictionaryWorkRiskEvents { get; set; }
        public virtual DbSet<VDictionaryWorkRiskEventCalc> VDictionaryWorkRiskEventCalcs { get; set; }
        public virtual DbSet<VDictionaryWorkRp> VDictionaryWorkRps { get; set; }
        public virtual DbSet<VDictionaryWorkStage> VDictionaryWorkStages { get; set; }
        public virtual DbSet<VDictionaryWorkStructure> VDictionaryWorkStructures { get; set; }
        public virtual DbSet<VDocumentExportHistory> VDocumentExportHistories { get; set; }
        public virtual DbSet<VDocumentRelation> VDocumentRelations { get; set; }
        public virtual DbSet<VDshbChrt14> VDshbChrt14s { get; set; }
        public virtual DbSet<VDshbChrt15> VDshbChrt15s { get; set; }
        public virtual DbSet<VDshbChrt16> VDshbChrt16s { get; set; }
        public virtual DbSet<VDshbChrt17> VDshbChrt17s { get; set; }
        public virtual DbSet<VDshbChrt18> VDshbChrt18s { get; set; }
        public virtual DbSet<VDshbChrt20> VDshbChrt20s { get; set; }
        public virtual DbSet<VDshbChrt22> VDshbChrt22s { get; set; }
        public virtual DbSet<VDshbChrt23> VDshbChrt23s { get; set; }
        public virtual DbSet<VDshbChrt24> VDshbChrt24s { get; set; }
        public virtual DbSet<VDshbChrt251> VDshbChrt251s { get; set; }
        public virtual DbSet<VDshbChrt252> VDshbChrt252s { get; set; }
        public virtual DbSet<VDshbChrt253> VDshbChrt253s { get; set; }
        public virtual DbSet<VDshbChrt254> VDshbChrt254s { get; set; }
        public virtual DbSet<VDshbChrt28> VDshbChrt28s { get; set; }
        public virtual DbSet<VDshbChrt29> VDshbChrt29s { get; set; }
        public virtual DbSet<VDshbChrt30> VDshbChrt30s { get; set; }
        public virtual DbSet<VEconomicEffect> VEconomicEffects { get; set; }
        public virtual DbSet<VEconomicEffectProject> VEconomicEffectProjects { get; set; }
        public virtual DbSet<VElementForTask> VElementForTasks { get; set; }
        public virtual DbSet<VElementForTaskLight> VElementForTaskLights { get; set; }
        public virtual DbSet<VEventMessage> VEventMessages { get; set; }
        public virtual DbSet<VExternalFile> VExternalFiles { get; set; }
        public virtual DbSet<VExternalFileArmRp> VExternalFileArmRps { get; set; }
        public virtual DbSet<VExternalFileArmRpLast> VExternalFileArmRpLasts { get; set; }
        public virtual DbSet<VFinanceLimit> VFinanceLimits { get; set; }
        public virtual DbSet<VFinanceLimitSpec> VFinanceLimitSpecs { get; set; }
        public virtual DbSet<VFinanceWorkPlaceAltDataHelper> VFinanceWorkPlaceAltDataHelpers { get; set; }
        public virtual DbSet<VFinanceWorkPlaceAltDatum> VFinanceWorkPlaceAltData { get; set; }
        public virtual DbSet<VFinanceWorkPlaceDatum> VFinanceWorkPlaceData { get; set; }
        public virtual DbSet<VFinancialChartAutomaticKa> VFinancialChartAutomaticKas { get; set; }
        public virtual DbSet<VFinancialChartDistributionBudget> VFinancialChartDistributionBudgets { get; set; }
        public virtual DbSet<VFinancialChartMannedFlight> VFinancialChartMannedFlights { get; set; }
        public virtual DbSet<VFinancialChartMannedFlightByType> VFinancialChartMannedFlightByTypes { get; set; }
        public virtual DbSet<VFinancialChartScheduleFinancing> VFinancialChartScheduleFinancings { get; set; }
        public virtual DbSet<VFinancialChartScheduleFinancingAll> VFinancialChartScheduleFinancingAlls { get; set; }
        public virtual DbSet<VFinancialChartTransport> VFinancialChartTransports { get; set; }
        public virtual DbSet<VFinancialManagement> VFinancialManagements { get; set; }
        public virtual DbSet<VGlobalGlobalEntry> VGlobalGlobalEntries { get; set; }
        public virtual DbSet<VGlobalGlobalEntryAttr> VGlobalGlobalEntryAttrs { get; set; }
        public virtual DbSet<VGlobalGlobalEntryList> VGlobalGlobalEntryLists { get; set; }
        public virtual DbSet<VGlobalGlobalEntryListRole> VGlobalGlobalEntryListRoles { get; set; }
        public virtual DbSet<VGroupParamGroup> VGroupParamGroups { get; set; }
        public virtual DbSet<VGroupParamParam> VGroupParamParams { get; set; }
        public virtual DbSet<VGroupWorkGroup> VGroupWorkGroups { get; set; }
        public virtual DbSet<VGroupWorkWork> VGroupWorkWorks { get; set; }
        public virtual DbSet<VHistoryState> VHistoryStates { get; set; }
        public virtual DbSet<VIntObligationIntObligation> VIntObligationIntObligations { get; set; }
        public virtual DbSet<VMmWork> VMmWorks { get; set; }
        public virtual DbSet<VMmWorkGroup> VMmWorkGroups { get; set; }
        public virtual DbSet<VMmWorkGroupPerson> VMmWorkGroupPeople { get; set; }
        public virtual DbSet<VMmWorkPerson> VMmWorkPeople { get; set; }
        public virtual DbSet<VMmWorkPersonContribution> VMmWorkPersonContributions { get; set; }
        public virtual DbSet<VMmWorkPersonParam> VMmWorkPersonParams { get; set; }
        public virtual DbSet<VMmWorkStage> VMmWorkStages { get; set; }
        public virtual DbSet<VObjectPriorityCriterion> VObjectPriorityCriteria { get; set; }
        public virtual DbSet<VObjectPriorityRank> VObjectPriorityRanks { get; set; }
        public virtual DbSet<VObjectiveObjective> VObjectiveObjectives { get; set; }
        public virtual DbSet<VOrbitalGroupDataOlap> VOrbitalGroupDataOlaps { get; set; }
        public virtual DbSet<VOrbitalGroupVariant> VOrbitalGroupVariants { get; set; }
        public virtual DbSet<VOrganization> VOrganizations { get; set; }
        public virtual DbSet<VParamParam> VParamParams { get; set; }
        public virtual DbSet<VParamValue> VParamValues { get; set; }
        public virtual DbSet<VPostDuty> VPostDuties { get; set; }
        public virtual DbSet<VPostPost> VPostPosts { get; set; }
        public virtual DbSet<VPriorityCriterionObject> VPriorityCriterionObjects { get; set; }
        public virtual DbSet<VPriorityCriterionRank> VPriorityCriterionRanks { get; set; }
        public virtual DbSet<VPriorityCriterionScale> VPriorityCriterionScales { get; set; }
        public virtual DbSet<VPriorityCriterionValue> VPriorityCriterionValues { get; set; }
        public virtual DbSet<VProjectPriorityDshb01> VProjectPriorityDshb01s { get; set; }
        public virtual DbSet<VProjectProject> VProjectProjects { get; set; }
        public virtual DbSet<VProjectTargetIndicator> VProjectTargetIndicators { get; set; }
        public virtual DbSet<VProjectUser> VProjectUsers { get; set; }
        public virtual DbSet<VPurposePurpose> VPurposePurposes { get; set; }
        public virtual DbSet<VRiskAvailableCalculatedValue> VRiskAvailableCalculatedValues { get; set; }
        public virtual DbSet<VRiskDamageValue> VRiskDamageValues { get; set; }
        public virtual DbSet<VRiskEvent> VRiskEvents { get; set; }
        public virtual DbSet<VRiskEventProbabilityValue> VRiskEventProbabilityValues { get; set; }
        public virtual DbSet<VRiskEventValue> VRiskEventValues { get; set; }
        public virtual DbSet<VRiskEventValueDetail> VRiskEventValueDetails { get; set; }
        public virtual DbSet<VSchedulerAppointment> VSchedulerAppointments { get; set; }
        public virtual DbSet<VSpaceLaunchSet> VSpaceLaunchSets { get; set; }
        public virtual DbSet<VSpaceLaunchSetGetKa> VSpaceLaunchSetGetKas { get; set; }
        public virtual DbSet<VSpaceLaunchSetGetOb> VSpaceLaunchSetGetObs { get; set; }
        public virtual DbSet<VSpaceLaunchSetGetRb> VSpaceLaunchSetGetRbs { get; set; }
        public virtual DbSet<VSpaceLaunchSetGetRn> VSpaceLaunchSetGetRns { get; set; }
        public virtual DbSet<VSpaceLaunchSetLight> VSpaceLaunchSetLights { get; set; }
        public virtual DbSet<VSpaceLaunchSetSpec> VSpaceLaunchSetSpecs { get; set; }
        public virtual DbSet<VSpaceLaunchSetSpecVersion> VSpaceLaunchSetSpecVersions { get; set; }
        public virtual DbSet<VSpacePolicyObjective> VSpacePolicyObjectives { get; set; }
        public virtual DbSet<VSpacePolicyObjectiveDirection> VSpacePolicyObjectiveDirections { get; set; }
        public virtual DbSet<VSpacePolicyObjectiveObjective> VSpacePolicyObjectiveObjectives { get; set; }
        public virtual DbSet<VSpaceSystemSpaceSystem> VSpaceSystemSpaceSystems { get; set; }
        public virtual DbSet<VSpacecraftSpacecraft> VSpacecraftSpacecrafts { get; set; }
        public virtual DbSet<VSpacecraftSpacecraftCalc> VSpacecraftSpacecraftCalcs { get; set; }
        public virtual DbSet<VSpacecraftSpacecraftCalcPlan> VSpacecraftSpacecraftCalcPlans { get; set; }
        public virtual DbSet<VSpacecraftSpacecraftLight> VSpacecraftSpacecraftLights { get; set; }
        public virtual DbSet<VSpacecraftSpacecraftSchedule> VSpacecraftSpacecraftSchedules { get; set; }
        public virtual DbSet<VSpacecraftSpacecraftScheduleCalc> VSpacecraftSpacecraftScheduleCalcs { get; set; }
        public virtual DbSet<VSpaceportCoordinate> VSpaceportCoordinates { get; set; }
        public virtual DbSet<VSpaseLaunchSetGetUnallocatedKa> VSpaseLaunchSetGetUnallocatedKas { get; set; }
        public virtual DbSet<VStageStage> VStageStages { get; set; }
        public virtual DbSet<VStructureAgentGroup> VStructureAgentGroups { get; set; }
        public virtual DbSet<VStructureElement> VStructureElements { get; set; }
        public virtual DbSet<VStructureElementEfficiency> VStructureElementEfficiencies { get; set; }
        public virtual DbSet<VStructureElementLight> VStructureElementLights { get; set; }
        public virtual DbSet<VStructureParam> VStructureParams { get; set; }
        public virtual DbSet<VStructureRelation> VStructureRelations { get; set; }
        public virtual DbSet<VStructureStructure> VStructureStructures { get; set; }
        public virtual DbSet<VStructureStructureEfficiency> VStructureStructureEfficiencies { get; set; }
        public virtual DbSet<VStructureStructureGetWorkGanttResourceTemp> VStructureStructureGetWorkGanttResourceTemps { get; set; }
        public virtual DbSet<VStructureStructureGetWorkGanttSession> VStructureStructureGetWorkGanttSessions { get; set; }
        public virtual DbSet<VStructureStructureLight> VStructureStructureLights { get; set; }
        public virtual DbSet<VStructureTargetIndicator> VStructureTargetIndicators { get; set; }
        public virtual DbSet<VStructureWorkDirection> VStructureWorkDirections { get; set; }
        public virtual DbSet<VSysAgentType> VSysAgentTypes { get; set; }
        public virtual DbSet<VSysColumnPermission> VSysColumnPermissions { get; set; }
        public virtual DbSet<VSysDictionaryWorkFinDirection> VSysDictionaryWorkFinDirections { get; set; }
        public virtual DbSet<VSysDictionaryWorkState> VSysDictionaryWorkStates { get; set; }
        public virtual DbSet<VSysEventKind> VSysEventKinds { get; set; }
        public virtual DbSet<VSysEventMessageType> VSysEventMessageTypes { get; set; }
        public virtual DbSet<VSysFinanceKind> VSysFinanceKinds { get; set; }
        public virtual DbSet<VSysKaState> VSysKaStates { get; set; }
        public virtual DbSet<VSysLinkType> VSysLinkTypes { get; set; }
        public virtual DbSet<VSysMmWorkGroupPersonRole> VSysMmWorkGroupPersonRoles { get; set; }
        public virtual DbSet<VSysMmWorkPersonParam> VSysMmWorkPersonParams { get; set; }
        public virtual DbSet<VSysMmWorkRapidKoef> VSysMmWorkRapidKoefs { get; set; }
        public virtual DbSet<VSysParamDataType> VSysParamDataTypes { get; set; }
        public virtual DbSet<VSysPriorityCriterionAttachment> VSysPriorityCriterionAttachments { get; set; }
        public virtual DbSet<VSysPriorityCriterionRankValue> VSysPriorityCriterionRankValues { get; set; }
        public virtual DbSet<VSysPriorityRankValueDescription> VSysPriorityRankValueDescriptions { get; set; }
        public virtual DbSet<VSysProjectType> VSysProjectTypes { get; set; }
        public virtual DbSet<VSysRelationType> VSysRelationTypes { get; set; }
        public virtual DbSet<VSysReportParamsLink> VSysReportParamsLinks { get; set; }
        public virtual DbSet<VSysResultKind> VSysResultKinds { get; set; }
        public virtual DbSet<VSysRiskValueDescription> VSysRiskValueDescriptions { get; set; }
        public virtual DbSet<VSysRnrbobState> VSysRnrbobStates { get; set; }
        public virtual DbSet<VSysSpacecraftState> VSysSpacecraftStates { get; set; }
        public virtual DbSet<VSysSystemIssuePriority> VSysSystemIssuePriorities { get; set; }
        public virtual DbSet<VSysSystemIssueState> VSysSystemIssueStates { get; set; }
        public virtual DbSet<VSysSystemIssueType> VSysSystemIssueTypes { get; set; }
        public virtual DbSet<VSysSystemSettingType> VSysSystemSettingTypes { get; set; }
        public virtual DbSet<VSysTargetIndicatorElementType> VSysTargetIndicatorElementTypes { get; set; }
        public virtual DbSet<VSysTargetIndicatorTrendType> VSysTargetIndicatorTrendTypes { get; set; }
        public virtual DbSet<VSysTaskElementChangeType> VSysTaskElementChangeTypes { get; set; }
        public virtual DbSet<VSysTaskElementState> VSysTaskElementStates { get; set; }
        public virtual DbSet<VSysTaskHistoryActionType> VSysTaskHistoryActionTypes { get; set; }
        public virtual DbSet<VSysTaskResultValueState> VSysTaskResultValueStates { get; set; }
        public virtual DbSet<VSysTaskState> VSysTaskStates { get; set; }
        public virtual DbSet<VSysTaskStepState> VSysTaskStepStates { get; set; }
        public virtual DbSet<VSysTechnicTypeClass> VSysTechnicTypeClasses { get; set; }
        public virtual DbSet<VSysUserArpParamsDataType> VSysUserArpParamsDataTypes { get; set; }
        public virtual DbSet<VSysUserGraphType> VSysUserGraphTypes { get; set; }
        public virtual DbSet<VSysVersionState> VSysVersionStates { get; set; }
        public virtual DbSet<VSysWorkAgentType> VSysWorkAgentTypes { get; set; }
        public virtual DbSet<VSysWorkParamCalculateType> VSysWorkParamCalculateTypes { get; set; }
        public virtual DbSet<VSysWorkType> VSysWorkTypes { get; set; }
        public virtual DbSet<VSysYear> VSysYears { get; set; }
        public virtual DbSet<VSystemAdminUpdateInfo> VSystemAdminUpdateInfos { get; set; }
        public virtual DbSet<VSystemAdminUpdateInfoSpec> VSystemAdminUpdateInfoSpecs { get; set; }
        public virtual DbSet<VSystemAllEntrye> VSystemAllEntryes { get; set; }
        public virtual DbSet<VSystemAudit> VSystemAudits { get; set; }
        public virtual DbSet<VSystemAuditLog> VSystemAuditLogs { get; set; }
        public virtual DbSet<VSystemBackup> VSystemBackups { get; set; }
        public virtual DbSet<VSystemCurrentUser> VSystemCurrentUsers { get; set; }
        public virtual DbSet<VSystemErrorLog> VSystemErrorLogs { get; set; }
        public virtual DbSet<VSystemGetNewId> VSystemGetNewIds { get; set; }
        public virtual DbSet<VSystemIssue> VSystemIssues { get; set; }
        public virtual DbSet<VSystemIssueAgent> VSystemIssueAgents { get; set; }
        public virtual DbSet<VSystemIssueAgentPerson> VSystemIssueAgentPeople { get; set; }
        public virtual DbSet<VSystemIssueCatalog> VSystemIssueCatalogs { get; set; }
        public virtual DbSet<VSystemIssueDepartment> VSystemIssueDepartments { get; set; }
        public virtual DbSet<VSystemIssueDictionary> VSystemIssueDictionaries { get; set; }
        public virtual DbSet<VSystemIssueHistory> VSystemIssueHistories { get; set; }
        public virtual DbSet<VSystemIssuePost> VSystemIssuePosts { get; set; }
        public virtual DbSet<VSystemLicense> VSystemLicenses { get; set; }
        public virtual DbSet<VSystemPermissionColumn> VSystemPermissionColumns { get; set; }
        public virtual DbSet<VSystemProcedure> VSystemProcedures { get; set; }
        public virtual DbSet<VSystemProcedureParameter> VSystemProcedureParameters { get; set; }
        public virtual DbSet<VSystemRole> VSystemRoles { get; set; }
        public virtual DbSet<VSystemRolePermissionAction> VSystemRolePermissionActions { get; set; }
        public virtual DbSet<VSystemRolePermissionActionCatalog> VSystemRolePermissionActionCatalogs { get; set; }
        public virtual DbSet<VSystemRolePermissionActionHelper> VSystemRolePermissionActionHelpers { get; set; }
        public virtual DbSet<VSystemRolePermissionColumn> VSystemRolePermissionColumns { get; set; }
        public virtual DbSet<VSystemRolePermissionEntry> VSystemRolePermissionEntries { get; set; }
        public virtual DbSet<VSystemRolePermissionUserReport> VSystemRolePermissionUserReports { get; set; }
        public virtual DbSet<VSystemRolePremissionPack> VSystemRolePremissionPacks { get; set; }
        public virtual DbSet<VSystemRoleUser> VSystemRoleUsers { get; set; }
        public virtual DbSet<VSystemSession> VSystemSessions { get; set; }
        public virtual DbSet<VSystemSetting> VSystemSettings { get; set; }
        public virtual DbSet<VSystemSqluser> VSystemSqlusers { get; set; }
        public virtual DbSet<VSystemUpdateApp> VSystemUpdateApps { get; set; }
        public virtual DbSet<VSystemUser> VSystemUsers { get; set; }
        public virtual DbSet<VSystemUserOrganization> VSystemUserOrganizations { get; set; }
        public virtual DbSet<VSystemUserPermissionColumn> VSystemUserPermissionColumns { get; set; }
        public virtual DbSet<VSystemUserPermissionMainAction> VSystemUserPermissionMainActions { get; set; }
        public virtual DbSet<VSystemUserPerson> VSystemUserPeople { get; set; }
        public virtual DbSet<VTargetIndicatorHelper10> VTargetIndicatorHelper10s { get; set; }
        public virtual DbSet<VTargetIndicatorHelper12> VTargetIndicatorHelper12s { get; set; }
        public virtual DbSet<VTargetIndicatorProject> VTargetIndicatorProjects { get; set; }
        public virtual DbSet<VTargetIndicatorTargetIndicator> VTargetIndicatorTargetIndicators { get; set; }
        public virtual DbSet<VTargetIndicatorTargetIndicatorEtalon> VTargetIndicatorTargetIndicatorEtalons { get; set; }
        public virtual DbSet<VTargetIndicatorTargetIndicatorWorkPlace> VTargetIndicatorTargetIndicatorWorkPlaces { get; set; }
        public virtual DbSet<VTaskElement> VTaskElements { get; set; }
        public virtual DbSet<VTaskElementByStep> VTaskElementBySteps { get; set; }
        public virtual DbSet<VTaskElementLight> VTaskElementLights { get; set; }
        public virtual DbSet<VTaskHistory> VTaskHistories { get; set; }
        public virtual DbSet<VTaskResultValue> VTaskResultValues { get; set; }
        public virtual DbSet<VTaskResultValueLight> VTaskResultValueLights { get; set; }
        public virtual DbSet<VTaskStep> VTaskSteps { get; set; }
        public virtual DbSet<VTaskStepElement> VTaskStepElements { get; set; }
        public virtual DbSet<VTaskTask> VTaskTasks { get; set; }
        public virtual DbSet<VTechnicCompatibility> VTechnicCompatibilities { get; set; }
        public virtual DbSet<VTechnicParam> VTechnicParams { get; set; }
        public virtual DbSet<VTechnicParamForTargetIndicator> VTechnicParamForTargetIndicators { get; set; }
        public virtual DbSet<VTechnicStatus> VTechnicStatuses { get; set; }
        public virtual DbSet<VTechnicType> VTechnicTypes { get; set; }
        public virtual DbSet<VTechnicTypeKa> VTechnicTypeKas { get; set; }
        public virtual DbSet<VTechnicTypeKaAnalog> VTechnicTypeKaAnalogs { get; set; }
        public virtual DbSet<VTechnicTypeOb> VTechnicTypeObs { get; set; }
        public virtual DbSet<VTechnicTypeParam> VTechnicTypeParams { get; set; }
        public virtual DbSet<VTechnicTypeRb> VTechnicTypeRbs { get; set; }
        public virtual DbSet<VTechnicTypeRn> VTechnicTypeRns { get; set; }
        public virtual DbSet<VTmpParamValue> VTmpParamValues { get; set; }
        public virtual DbSet<VUserApplication> VUserApplications { get; set; }
        public virtual DbSet<VUserApplicationApplication> VUserApplicationApplications { get; set; }
        public virtual DbSet<VUserArpParam> VUserArpParams { get; set; }
        public virtual DbSet<VUserArpParamsLinked> VUserArpParamsLinkeds { get; set; }
        public virtual DbSet<VUserArpParamsList> VUserArpParamsLists { get; set; }
        public virtual DbSet<VUserArpSection> VUserArpSections { get; set; }
        public virtual DbSet<VUserGraphGraph> VUserGraphGraphs { get; set; }
        public virtual DbSet<VUserGraphUnload> VUserGraphUnloads { get; set; }
        public virtual DbSet<VUserProcedure> VUserProcedures { get; set; }
        public virtual DbSet<VUserProcedureProcedure> VUserProcedureProcedures { get; set; }
        public virtual DbSet<VUserProfile> VUserProfiles { get; set; }
        public virtual DbSet<VUserReport> VUserReports { get; set; }
        public virtual DbSet<VUserReportReport> VUserReportReports { get; set; }
        public virtual DbSet<VUserReportRole> VUserReportRoles { get; set; }
        public virtual DbSet<VUserReportSection> VUserReportSections { get; set; }
        public virtual DbSet<VUserReportUnload> VUserReportUnloads { get; set; }
        public virtual DbSet<VUserReportsParam> VUserReportsParams { get; set; }
        public virtual DbSet<VUserVersion> VUserVersions { get; set; }
        public virtual DbSet<VVersionCompareSpec1> VVersionCompareSpec1s { get; set; }
        public virtual DbSet<VVersionCompareSpec2> VVersionCompareSpec2s { get; set; }
        public virtual DbSet<VVersionCompareSpec3> VVersionCompareSpec3s { get; set; }
        public virtual DbSet<VVersionCompareSpec4> VVersionCompareSpec4s { get; set; }
        public virtual DbSet<VVersionTaskResult> VVersionTaskResults { get; set; }
        public virtual DbSet<VVersionVersion> VVersionVersions { get; set; }
        public virtual DbSet<VWorkAgent> VWorkAgents { get; set; }
        public virtual DbSet<VWorkCode> VWorkCodes { get; set; }
        public virtual DbSet<VWorkDirection> VWorkDirections { get; set; }
        public virtual DbSet<VWorkDirectionParam> VWorkDirectionParams { get; set; }
        public virtual DbSet<VWorkDirectionProject> VWorkDirectionProjects { get; set; }
        public virtual DbSet<VWorkDocument> VWorkDocuments { get; set; }
        public virtual DbSet<VWorkFinanceWorkPlace> VWorkFinanceWorkPlaces { get; set; }
        public virtual DbSet<VWorkFinanceWorkPlaceDshb01> VWorkFinanceWorkPlaceDshb01s { get; set; }
        public virtual DbSet<VWorkFinanceWorkPlaceDshb03> VWorkFinanceWorkPlaceDshb03s { get; set; }
        public virtual DbSet<VWorkFinanceWorkPlaceDshb05> VWorkFinanceWorkPlaceDshb05s { get; set; }
        public virtual DbSet<VWorkFinanceWorkPlaceDshb31> VWorkFinanceWorkPlaceDshb31s { get; set; }
        public virtual DbSet<VWorkOrbitalGroupWorkPlace> VWorkOrbitalGroupWorkPlaces { get; set; }
        public virtual DbSet<VWorkParam> VWorkParams { get; set; }
        public virtual DbSet<VWorkPriorityDshb01> VWorkPriorityDshb01s { get; set; }
        public virtual DbSet<VWorkRelation> VWorkRelations { get; set; }
        public virtual DbSet<VWorkSection> VWorkSections { get; set; }
        public virtual DbSet<VWorkStage> VWorkStages { get; set; }
        public virtual DbSet<VWorkWork> VWorkWorks { get; set; }
        public virtual DbSet<VWorkWorkRp> VWorkWorkRps { get; set; }
        public virtual DbSet<VWorkWorkRpHelper> VWorkWorkRpHelpers { get; set; }
        public virtual DbSet<VersionCopyHelper> VersionCopyHelpers { get; set; }
        public virtual DbSet<VersionVersion> VersionVersions { get; set; }
        public virtual DbSet<WorkAgent> WorkAgents { get; set; }
        public virtual DbSet<WorkCode> WorkCodes { get; set; }
        public virtual DbSet<WorkDirection> WorkDirections { get; set; }
        public virtual DbSet<WorkDirectionParam> WorkDirectionParams { get; set; }
        public virtual DbSet<WorkDocument> WorkDocuments { get; set; }
        public virtual DbSet<WorkParam> WorkParams { get; set; }
        public virtual DbSet<WorkRelation> WorkRelations { get; set; }
        public virtual DbSet<WorkSection> WorkSections { get; set; }
        public virtual DbSet<WorkStage> WorkStages { get; set; }
        public virtual DbSet<WorkWork> WorkWorks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=FKPSystem;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<AgentAgent>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Agent#Ag__CAFF4132C8C90715");

                entity.ToTable("Agent#Agent");

                entity.HasIndex(e => e.Rid, "IDX_Name");

                entity.HasIndex(e => e.Rid, "_dta_index_Agent#Agent_10_17539246__K1_2");

                entity.HasIndex(e => e.Rid, "_dta_index_Agent#Agent_5_17539246__K1_2");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.AddName).HasMaxLength(2000);

                entity.Property(e => e.Address).HasMaxLength(2000);

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Cpp)
                    .HasMaxLength(50)
                    .HasColumnName("CPP");

                entity.Property(e => e.DateR).HasColumnType("smalldatetime");

                entity.Property(e => e.FirstName).HasMaxLength(260);

                entity.Property(e => e.Inn)
                    .HasMaxLength(50)
                    .HasColumnName("INN");

                entity.Property(e => e.LastName).HasMaxLength(260);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Ogrn)
                    .HasMaxLength(50)
                    .HasColumnName("OGRN");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(50)
                    .HasColumnName("OKPO");

                entity.Property(e => e.Patronymic).HasMaxLength(260);

                entity.HasOne(d => d.AgentCategoryNavigation)
                    .WithMany(p => p.AgentAgents)
                    .HasForeignKey(d => d.AgentCategory)
                    .HasConstraintName("FK_Agent#Agent_Dictionary#Dictionary");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.AgentAgents)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agent#Age__Catal__6C44C29B");
            });

            modelBuilder.Entity<AgentContact>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Agent#Co__CAFF4132B6F0FAF7");

                entity.ToTable("Agent#Contact");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.ContactValue).HasMaxLength(2000);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.AgentContacts)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agent#Con__Agent__6D38E6D4");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.AgentContacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agent#Con__Conta__6E2D0B0D");
            });

            modelBuilder.Entity<AgentGroupAgent>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__AgentGro__CAFF4132AA00734D");

                entity.ToTable("AgentGroup#Agent");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Идентификатор");

                entity.Property(e => e.AgentId)
                    .HasColumnName("AgentID")
                    .HasComment("Идентификатор контрагента");

                entity.Property(e => e.OrderNum).HasComment("Номер сортировки");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasComment("Идентификатор группы");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.AgentGroupAgents)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AgentGrou__Agent__74DA089C");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AgentGroupAgents)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AgentGrou__Paren__73E5E463");
            });

            modelBuilder.Entity<AgentGroupGroup>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__AgentGro__CAFF41324B9AC933");

                entity.ToTable("AgentGroup#Group");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.AgentGroupGroups)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AgentGrou__Catal__75CE2CD5");
            });

            modelBuilder.Entity<AgentPerson>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Agent#Pe__CAFF4132275DF151");

                entity.ToTable("Agent#Person");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AcademicDegree).HasMaxLength(250);

                entity.Property(e => e.AcademicTitle).HasMaxLength(250);

                entity.Property(e => e.AddEducation).HasMaxLength(2000);

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Education).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.ProffKoef).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TabNum).HasMaxLength(50);

                entity.Property(e => e.WorkExp).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.AgentPeople)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agent#Per__Agent__7015537F");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.AgentPeople)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agent#Per__Catal__6F212F46");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AgentPeople)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Agent#Per__Categ__72F1C02A");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.AgentPeople)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agent#Per__Depar__71FD9BF1");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.AgentPeople)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agent#Per__PostI__710977B8");
            });

            modelBuilder.Entity<CatalogCatalog>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Catalog#__CAFF4132C5ACF8EB");

                entity.ToTable("Catalog#Catalog");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.CatalogCatalogs)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Catalog#C__Entry__15DB09B4");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Catalog#Cat__RID__76C2510E");
            });

            modelBuilder.Entity<DashboardFilter>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("DashboardFilter");

                entity.HasIndex(e => new { e.ParentId, e.UserName }, "IDX_ParentID_UserName_FilterValue");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.DashboardFilters)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_DashboardFilter_Graph");
            });

            modelBuilder.Entity<DepartmentDepartment>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Departme__CAFF413284BCD1BA");

                entity.ToTable("Department#Department");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DepartmentDepartments)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Departmen__Categ__07ECDD10");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Departmen__Paren__06F8B8D7");
            });

            modelBuilder.Entity<DictionaryDictionary>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Dictiona__CAFF413260B06A40");

                entity.ToTable("Dictionary#Dictionary");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.DictionaryDictionaries)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Dictionar__Entry__09D52582");
            });

            modelBuilder.Entity<DictionaryEventType>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#EventType");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Dictionary#EventType_Dictionary#EventType");
            });

            modelBuilder.Entity<DictionaryLink>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#Link");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID")
                    .HasComment("Идентификатор");

                entity.Property(e => e.AppNum).HasComment("Номер приложения документа");

                entity.Property(e => e.CatalogId)
                    .HasColumnName("CatalogID")
                    .HasComment("Каталог");

                entity.Property(e => e.Name)
                    .HasMaxLength(2000)
                    .HasComment("Текст");

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .HasComment("Примечание");

                entity.Property(e => e.Num).HasComment("Порядковый номер");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.DictionaryLinks)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Link_Catalog#Catalog");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.DictionaryLinks)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Dictionary#Link_Version#Version");
            });

            modelBuilder.Entity<DictionaryMeasure>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Dictiona__CAFF41326E410A14");

                entity.ToTable("Dictionary#Measure");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.NativCode).HasMaxLength(50);

                entity.Property(e => e.ShortName).HasMaxLength(2000);

                entity.Property(e => e.UniCode).HasMaxLength(50);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.DictionaryMeasures)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Dictionar__Catal__0AC949BB");
            });

            modelBuilder.Entity<DictionaryPriorityCriterion>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#PriorityCriterion");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsAutoCalc).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsCalculated)
                    .HasColumnName("isCalculated")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Разрешить вычисление критерия");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DictionaryPriorityCriteria)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#PriorityCriterion_Category");
            });

            modelBuilder.Entity<DictionaryRisk>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#Risk");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActual)
                    .HasColumnName("isActual")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.DictionaryRisks)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Risk_Catalog");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DictionaryRisks)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Risk_Type");
            });

            modelBuilder.Entity<DictionaryStageType>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#StageType");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Gostid).HasColumnName("GOSTID");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.TechnologyReadyLevelId).HasColumnName("TechnologyReadyLevelID");

                entity.Property(e => e.WorkKindId).HasColumnName("WorkKindID");

                entity.HasOne(d => d.Gost)
                    .WithMany(p => p.DictionaryStageTypeGosts)
                    .HasForeignKey(d => d.Gostid)
                    .HasConstraintName("FK_Dictionary#StageType_Dictionary#Dictionary1");

                entity.HasOne(d => d.TechnologyReadyLevel)
                    .WithMany(p => p.DictionaryStageTypes)
                    .HasForeignKey(d => d.TechnologyReadyLevelId)
                    .HasConstraintName("FK_Dictionary#StageType_TechnologyReadyLevelID");

                entity.HasOne(d => d.WorkKind)
                    .WithMany(p => p.DictionaryStageTypeWorkKinds)
                    .HasForeignKey(d => d.WorkKindId)
                    .HasConstraintName("FK_Dictionary#StageType_Dictionary#Dictionary");
            });

            modelBuilder.Entity<DictionaryTargetIndicator>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#TargetIndicator");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_RID_Name_MeasureID");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Dashboard).HasColumnType("image");

                entity.Property(e => e.IsCalcEfficiency).HasColumnName("isCalcEfficiency");

                entity.Property(e => e.IsPrint).HasColumnName("isPrint");

                entity.Property(e => e.IsUpdate)
                    .HasColumnName("isUpdate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ManualEdit).HasDefaultValueSql("((0))");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.Method).HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ProcedureName).HasMaxLength(50);

                entity.Property(e => e.SFormat)
                    .HasMaxLength(100)
                    .HasColumnName("sFormat");

                entity.Property(e => e.ShortName).HasMaxLength(250);

                entity.Property(e => e.TrendType).HasDefaultValueSql("((0))");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.DictionaryTargetIndicators)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Dictionary#TargetIndicator_Version#Version");
            });

            modelBuilder.Entity<DictionaryTechnic>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Dictiona__CAFF4132EC902AFC");

                entity.ToTable("Dictionary#Technic");

                entity.HasIndex(e => e.Rid, "IDX_RID_EntryID");

                entity.HasIndex(e => new { e.EntryId, e.Rid }, "_dta_index_Dictionary#Technic_5_1595972862__K10_K1");

                entity.HasIndex(e => new { e.EntryId, e.Rid, e.TypeId }, "_dta_index_Dictionary#Technic_5_1595972862__K10_K1_K8");

                entity.HasIndex(e => new { e.EntryId, e.Rid, e.TypeId }, "_dta_index_Dictionary#Technic_5_1595972862__K10_K1_K8_3_4_7_9");

                entity.HasIndex(e => e.Rid, "_dta_index_Dictionary#Technic_5_1595972862__K1_2894");

                entity.HasIndex(e => e.Rid, "_dta_index_Dictionary#Technic_5_1595972862__K1_3_4_7_8_9_10");

                entity.HasIndex(e => new { e.Rid, e.TypeId }, "_dta_index_Dictionary#Technic_5_1595972862__K1_K8");

                entity.HasIndex(e => new { e.TypeId, e.Rid }, "_dta_index_Dictionary#Technic_5_1595972862__K8_K1_4");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.FlightModel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.DictionaryTechnics)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Dictionar__Catal__0BBD6DF4");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.DictionaryTechnics)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK_Dictionary#Technic_Global#GlobalEntry");
            });

            modelBuilder.Entity<DictionaryTechnicAnalog>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#Technic#Analog");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.AnalogId).HasColumnName("AnalogID");

                entity.Property(e => e.TechnicId).HasColumnName("TechnicID");

                entity.HasOne(d => d.Analog)
                    .WithMany(p => p.DictionaryTechnicAnalogAnalogs)
                    .HasForeignKey(d => d.AnalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Technic#Analog_Analog");

                entity.HasOne(d => d.Technic)
                    .WithMany(p => p.DictionaryTechnicAnalogTechnics)
                    .HasForeignKey(d => d.TechnicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Technic#Analog_Technic");
            });

            modelBuilder.Entity<DictionaryTechnologyReadyLevel>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#Technology#Ready#Level");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RealizeForm).HasMaxLength(500);
            });

            modelBuilder.Entity<DictionaryWork>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Dictiona__CAFF41326B6EAEED");

                entity.ToTable("Dictionary#Work");

                entity.HasIndex(e => e.ParentId, "IDX_ParentID");

                entity.HasIndex(e => new { e.Rid, e.StageOrder }, "IDX_RID_StageOrder");

                entity.HasIndex(e => e.WorkType, "IDX_WT_RID_Code_Name_StageOrder_WCID_Parent");

                entity.HasIndex(e => e.WorkType, "IDX_WorkType_RID");

                entity.HasIndex(e => e.Rid, "_dta_index_Dictionary#Work_5_1465264475__K1_2");

                entity.HasIndex(e => new { e.SectionId, e.Rid, e.WorkCodeId }, "_dta_index_Dictionary#Work_5_532301056__K17_K1_K11");

                entity.HasIndex(e => new { e.Rid, e.SectionId, e.KindId, e.WorkCodeId }, "_dta_index_Dictionary#Work_5_532301056__K1_K17_K23_K11_4_5_6_8_15");

                entity.HasIndex(e => new { e.WorkType, e.SectionId, e.Rid, e.WorkCodeId }, "_dta_index_Dictionary#Work_6_532301056__K24_K17_K1_K11_5_8_15");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Gostid).HasColumnName("GOSTID");

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PrintName).HasMaxLength(1000);

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.StagePercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StageTypeId).HasColumnName("StageTypeID");

                entity.Property(e => e.StageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.DictionaryWorks)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Dictionar__Catal__0E99DA9F");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DictionaryWorkCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Dictionar__Categ__10822311");

                entity.HasOne(d => d.Gost)
                    .WithMany(p => p.DictionaryWorkGosts)
                    .HasForeignKey(d => d.Gostid)
                    .HasConstraintName("FK_Dictionary#Work_Dictionary#Dictionary_GOST");

                entity.HasOne(d => d.Kind)
                    .WithMany(p => p.DictionaryWorkKinds)
                    .HasForeignKey(d => d.KindId);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Dictionary#Work_Parent");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DictionaryWorks)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Dictionary#Work_Project#Project");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.DictionaryWorks)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Dictionary#Work_Section");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.DictionaryWorks)
                    .HasForeignKey(d => d.StageId)
                    .HasConstraintName("FK_Dictionary#Work_StageID");

                entity.HasOne(d => d.StageType)
                    .WithMany(p => p.DictionaryWorks)
                    .HasForeignKey(d => d.StageTypeId)
                    .HasConstraintName("FK_Dictionary#Work_Dictionary#StageType");

                entity.HasOne(d => d.WorkCode)
                    .WithMany(p => p.DictionaryWorks)
                    .HasForeignKey(d => d.WorkCodeId)
                    .HasConstraintName("FK__Dictionar__WorkC__1176474A");
            });

            modelBuilder.Entity<DictionaryWorkEvent>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#Work#Event");

                entity.HasIndex(e => e.EventTypeId, "IDX_DWE_DWID_VersionID_DateTo_Value");

                entity.HasIndex(e => new { e.DictionaryWorkId, e.VersionId, e.EventTypeId }, "IDX_DWID_Ver_EventType_Date_Value");

                entity.HasIndex(e => new { e.DictionaryWorkId, e.VersionId, e.DateTo }, "IDX_DWID_Version_DateTo");

                entity.HasIndex(e => e.EventTypeId, "IDX_EventTypeID_AllFields");

                entity.HasIndex(e => e.SpacecraftId, "IDX_SpacecraftID");

                entity.HasIndex(e => new { e.VersionId, e.DictionaryValueId }, "IDX_VersionID_DicValueID");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_DicWorkID_DateTo");

                entity.HasIndex(e => new { e.VersionId, e.EventTypeId }, "IDX_VersionID_EvetTypeID");

                entity.HasIndex(e => new { e.EventTypeId, e.VersionId, e.DictionaryWorkId }, "_dta_index_Dictionary#Work#Event_10_845350176__K5_K3_K2_9");

                entity.HasIndex(e => new { e.VersionId, e.EventTypeId, e.DictionaryWorkId }, "_dta_index_Dictionary#Work#Event_5_2032218490__K3_K5_K2_7_9");

                entity.HasIndex(e => new { e.EventTypeId, e.VersionId, e.DictionaryWorkId, e.Rid, e.UseInCalc, e.DateTo }, "_dta_index_Dictionary#Work#Event_6_832214215__K5_K3_K2_K1_K11_K7_9");

                entity.HasIndex(e => e.UseInCalc, "index_388_387_Dictionary#Work#Event");

                entity.HasIndex(e => e.UseInCalc, "index_392_391_Dictionary#Work#Event");

                entity.HasIndex(e => e.ParentEventId, "index_422_421_Dictionary#Work#Event");

                entity.HasIndex(e => e.VersionId, "missing_index_618_617_Dictionary#Work#Event");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.DictionaryWorkId).HasColumnName("DictionaryWorkID");

                entity.Property(e => e.EventPercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.IsAnnualy).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDone)
                    .HasColumnName("isDone")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.ParentEventId).HasColumnName("ParentEventID");

                entity.Property(e => e.SpacecraftId).HasColumnName("SpacecraftID");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.EventType)
                    .WithMany(p => p.DictionaryWorkEvents)
                    .HasForeignKey(d => d.EventTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Work#Event_EventTypeID");

                entity.HasOne(d => d.Measure)
                    .WithMany(p => p.DictionaryWorkEvents)
                    .HasForeignKey(d => d.MeasureId)
                    .HasConstraintName("FK_Dictionary#Work#Event_MeasureID");

                entity.HasOne(d => d.ParentEvent)
                    .WithMany(p => p.InverseParentEvent)
                    .HasForeignKey(d => d.ParentEventId)
                    .HasConstraintName("FK_Dictionary#Work#Event_ParentEventID");

                entity.HasOne(d => d.Spacecraft)
                    .WithMany(p => p.DictionaryWorkEvents)
                    .HasForeignKey(d => d.SpacecraftId)
                    .HasConstraintName("FK_Dictionary#Work#Event_SpacecraftID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.DictionaryWorkEvents)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Dictionary#Work#Event_VersionID");
            });

            modelBuilder.Entity<DictionaryWorkEventFin>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_Dictionary#Work#Event#Relation");

                entity.ToTable("Dictionary#Work#Event#Fin");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.FinId).HasColumnName("FinID");

                entity.Property(e => e.NSum)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.DictionaryWorkEventFinEvents)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Work#Event#Fin_EventID");

                entity.HasOne(d => d.Fin)
                    .WithMany(p => p.DictionaryWorkEventFinFins)
                    .HasForeignKey(d => d.FinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Work#Event#Fin_FinID");
            });

            modelBuilder.Entity<DictionaryWorkEventTechnic>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_Work#Event#Techic");

                entity.ToTable("Dictionary#Work#Event#Technic");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.TechnicId).HasColumnName("TechnicID");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.DictionaryWorkEventTechnics)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Work#Event#Technic_EventID");

                entity.HasOne(d => d.Technic)
                    .WithMany(p => p.DictionaryWorkEventTechnics)
                    .HasForeignKey(d => d.TechnicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Work#Event#Technic_TechnicID");
            });

            modelBuilder.Entity<DictionaryWorkEventUndo>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#Work#Event#Undo");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Dweid).HasColumnName("DWEID");

                entity.Property(e => e.Dwid).HasColumnName("DWID");

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ValueAfter).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValueBefore).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<DictionaryWorkParam>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#Work#Param");

                entity.HasIndex(e => e.VersionId, "IDX_DWP_Version_All");

                entity.HasIndex(e => new { e.ParentId, e.VersionId }, "IDX_ParentID_VersionID_AllFields");

                entity.HasIndex(e => e.VersionId, "IDX_Version_RID_ParentID");

                entity.HasIndex(e => e.VersionId, "_dta_index_Dictionary#Work#Param_5_163635776__K3_2_6");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.BaseRank).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PrintName).HasMaxLength(1000);

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StagePercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.State).HasDefaultValueSql("((0))");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.DictionaryWorkParams)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Work#Param_ParentID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.DictionaryWorkParams)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Work#Param_VersionID");
            });

            modelBuilder.Entity<DictionaryWorkRiskEvent>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Dictionary#Work#Risk#Event");

                entity.HasIndex(e => new { e.DictionaryWorkId, e.VersionId }, "IDX_DW_Version_RID_RiskID_Note");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_RID");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.DictionaryRiskId).HasColumnName("DictionaryRiskID");

                entity.Property(e => e.DictionaryWorkId).HasColumnName("DictionaryWorkID");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.DictionaryRisk)
                    .WithMany(p => p.DictionaryWorkRiskEvents)
                    .HasForeignKey(d => d.DictionaryRiskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Work#Risk#Event_Risk");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.DictionaryWorkRiskEvents)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dictionary#Work#Risk#Event_Version");
            });

            modelBuilder.Entity<DocumentExportHistory>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Document__CAFF41327A6D0DBE");

                entity.ToTable("Document#ExportHistory");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AgentFromId).HasColumnName("AgentFromID");

                entity.Property(e => e.AgentToId).HasColumnName("AgentToID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.Email)
                    .HasMaxLength(260)
                    .HasColumnName("EMail");

                entity.Property(e => e.ExportDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.UserName).HasMaxLength(260);

                entity.HasOne(d => d.AgentFrom)
                    .WithMany(p => p.DocumentExportHistoryAgentFroms)
                    .HasForeignKey(d => d.AgentFromId)
                    .HasConstraintName("FK__Document#__Agent__126A6B83");

                entity.HasOne(d => d.AgentTo)
                    .WithMany(p => p.DocumentExportHistoryAgentTos)
                    .HasForeignKey(d => d.AgentToId)
                    .HasConstraintName("FK__Document#__Agent__135E8FBC");
            });

            modelBuilder.Entity<DocumentRelation>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Document#Relation");

                entity.HasIndex(e => e.DocIn, "IDX_DocIN");

                entity.HasIndex(e => e.Rid, "IDX_RID_Covering");

                entity.HasIndex(e => new { e.DocIn, e.Rid, e.DocOut }, "_dta_index_Document#Relation_10_1593160821__K2_K1_K3");

                entity.HasIndex(e => e.DocOut, "index_174_173_Document#Relation");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.EntryIdin).HasColumnName("EntryIDIn");

                entity.Property(e => e.EntryIdout).HasColumnName("EntryIDOut");

                entity.Property(e => e.Koeff1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LinkType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.HasOne(d => d.EntryIdinNavigation)
                    .WithMany(p => p.DocumentRelationEntryIdinNavigations)
                    .HasForeignKey(d => d.EntryIdin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document#Relation_EntryIDIn");

                entity.HasOne(d => d.EntryIdoutNavigation)
                    .WithMany(p => p.DocumentRelationEntryIdoutNavigations)
                    .HasForeignKey(d => d.EntryIdout)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document#Relation_EntryIDOut");
            });

            modelBuilder.Entity<EconomicEffect>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Economic#Effect");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Sum1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum10).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum4).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum5).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum6).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum7).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum8).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum9).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ValueType).HasDefaultValueSql("((0))");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.EconomicEffects)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Economic#Effect_Version");
            });

            modelBuilder.Entity<EconomicEffectProject>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Economic#Effect#Project");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.EconomicEffectProjects)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Economic#Effect#Project_ParentID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.EconomicEffectProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Economic#Effect#Project_ProjectID");
            });

            modelBuilder.Entity<EventMessage>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Event#Message");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.EventDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventEndDate).HasColumnType("datetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.HostName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.IsActual)
                    .HasColumnName("isActual")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageText).IsRequired();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<ExternalDocument>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__External__CAFF413286761569");

                entity.ToTable("External#Document");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.DirectDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DocDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DocNum).HasMaxLength(50);

                entity.Property(e => e.DocTypeId).HasColumnName("DocTypeID");

                entity.Property(e => e.ExternalNum).HasMaxLength(50);

                entity.Property(e => e.FileData).HasMaxLength(1);

                entity.Property(e => e.FileName).HasMaxLength(260);

                entity.Property(e => e.ImportDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.ExternalDocuments)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK__External#__Agent__1452B3F5");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.ExternalDocuments)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__External#__Catal__1546D82E");

                entity.HasOne(d => d.DocType)
                    .WithMany(p => p.ExternalDocuments)
                    .HasForeignKey(d => d.DocTypeId)
                    .HasConstraintName("FK__External#__DocTy__163AFC67");
            });

            modelBuilder.Entity<ExternalFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("External#File");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Description)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.DocPref)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fdata)
                    .HasColumnType("image")
                    .HasColumnName("FData");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.InDate).HasColumnType("date");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.HasOne(d => d.Agent)
                    .WithMany()
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK_External#File_Agent#Agent");

                entity.HasOne(d => d.Catalog)
                    .WithMany()
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_External#File_Catalog#Catalog");
            });

            modelBuilder.Entity<FinanceLimit>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Finance#Limit");

                entity.HasIndex(e => e.NYear, "_dta_index_Finance#Limit_6_1311447846__K3_2_4");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.NSum)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum");

                entity.Property(e => e.NSum1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum1");

                entity.Property(e => e.NSum2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum2");

                entity.Property(e => e.NSum3)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum3");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<FinanceLimitSpec>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Finance#Limit#Spec");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.NSum)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.WorkSectionId).HasColumnName("WorkSectionID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.FinanceLimitSpecs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Finance#Limit#Spec_Finance#Limit");

                entity.HasOne(d => d.WorkSection)
                    .WithMany(p => p.FinanceLimitSpecs)
                    .HasForeignKey(d => d.WorkSectionId)
                    .HasConstraintName("FK_Finance#Limit#Spec_Work#Section");
            });

            modelBuilder.Entity<FinanceWorkPlaceDataHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceWorkPlace#Data#History");

                entity.Property(e => e.NValue)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nValue");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SetDate).HasColumnType("date");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.ValueId).HasColumnName("ValueID");
            });

            modelBuilder.Entity<FinanceWorkPlaceDataUndo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceWorkPlace#Data#Undo");

                entity.Property(e => e.NValue)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nValue");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SetDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.ValueId).HasColumnName("ValueID");
            });

            modelBuilder.Entity<FinanceWorkPlaceDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FinanceWorkPlace#Data");

                entity.Property(e => e.LimitSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.Property(e => e.Версия)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ВидФинансирования)
                    .HasMaxLength(50)
                    .HasColumnName("Вид финансирования");

                entity.Property(e => e.ЗначениеФинансовогоПоказателя)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Значение финансового показателя");

                entity.Property(e => e.ЗначениеФинансовогоПоказателяДо)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Значение финансового показателя до");

                entity.Property(e => e.НаименованиеМероприятия)
                    .HasMaxLength(1000)
                    .HasColumnName("Наименование мероприятия");

                entity.Property(e => e.НомерМероприятияВПрограмме)
                    .HasMaxLength(55)
                    .HasColumnName("Номер мероприятия в программе");

                entity.Property(e => e.Подраздел).HasMaxLength(100);

                entity.Property(e => e.ПоказательФинансированияПоГодам).HasColumnName("Показатель финансирования по годам");

                entity.Property(e => e.Пункт).HasMaxLength(100);

                entity.Property(e => e.Раздел).HasMaxLength(500);

                entity.Property(e => e.РегистрационныйНомерМероприятия)
                    .HasMaxLength(55)
                    .HasColumnName("Регистрационный номер мероприятия");

                entity.Property(e => e.СокрНаименование)
                    .HasMaxLength(1000)
                    .HasColumnName("Сокр. наименование");

                entity.Property(e => e.Статья).HasMaxLength(100);

                entity.Property(e => e.ШифрПроекта)
                    .HasMaxLength(1000)
                    .HasColumnName("Шифр проекта");
            });

            modelBuilder.Entity<GlobalGlobalEntry>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Global#G__CAFF4132E40005C0");

                entity.ToTable("Global#GlobalEntry");

                entity.HasIndex(e => new { e.Rid, e.SystemName }, "IDX_RID_SystemName");

                entity.HasIndex(e => e.Rid, "_dta_index_Global#GlobalEntry_10_441872741__K1_4");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClassLib).HasMaxLength(250);

                entity.Property(e => e.ClassName).HasMaxLength(250);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EditClassName).HasMaxLength(250);

                entity.Property(e => e.IsOnlyChildUse).HasColumnName("isOnlyChildUse");

                entity.Property(e => e.IsRelation)
                    .HasColumnName("isRelation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSystem)
                    .HasColumnName("isSystem")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<GlobalGlobalEntryAttr>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Global#G__CAFF41324194C5A4");

                entity.ToTable("Global#GlobalEntryAttr");

                entity.HasIndex(e => new { e.AttGroup, e.AttDomain }, "IX_Global#GlobalEntryAttr_missing_110");

                entity.HasIndex(e => e.ParentId, "IX_Global#GlobalEntryAttr_missing_1166");

                entity.HasIndex(e => e.AttDomain, "IX_Global#GlobalEntryAttr_missing_121");

                entity.HasIndex(e => e.AttDomain, "IX_Global#GlobalEntryAttr_missing_125");

                entity.HasIndex(e => e.AttDomain, "IX_Global#GlobalEntryAttr_missing_126");

                entity.HasIndex(e => e.AttDomain, "IX_Global#GlobalEntryAttr_missing_130");

                entity.HasIndex(e => new { e.AttDomain, e.ParentId }, "IX_Global#GlobalEntryAttr_missing_43");

                entity.HasIndex(e => new { e.AttGroup, e.AttDomain }, "IX_Global#GlobalEntryAttr_missing_45");

                entity.HasIndex(e => e.ParentId, "IX_Global#GlobalEntryAttr_missing_47");

                entity.HasIndex(e => e.ParentId, "IX_Global#GlobalEntryAttr_missing_49");

                entity.HasIndex(e => new { e.ParentId, e.AttDomain }, "IX_Global#GlobalEntryAttr_missing_54");

                entity.HasIndex(e => new { e.AttGroup, e.AttDomain }, "IX_Global#GlobalEntryAttr_missing_56");

                entity.HasIndex(e => new { e.AttGroup, e.AttDomain }, "IX_Global#GlobalEntryAttr_missing_68");

                entity.HasIndex(e => new { e.ParentId, e.AttType, e.AttDomain }, "IX_Global#GlobalEntryAttr_missing_80");

                entity.HasIndex(e => e.ParentId, "IX_Global#GlobalEntryAttr_missing_960");

                entity.HasIndex(e => new { e.Rid, e.AttDomain, e.ParentId }, "_dta_index_Global#GlobalEntryAttr_5_331200280__K1_K7_K9_4_6");

                entity.HasIndex(e => new { e.AttDomain, e.AttCaption, e.AttGroup, e.Rid }, "_dta_index_Global#GlobalEntryAttr_5_331200280__K7_K4_K6_K1");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AttCaption).HasMaxLength(100);

                entity.Property(e => e.AttDataType).HasMaxLength(50);

                entity.Property(e => e.AttDomain).HasComment("1 - столбец GridView, 2 - столбец TreeList, 3 - кнопка (действие)");

                entity.Property(e => e.AttFieldName).HasMaxLength(50);

                entity.Property(e => e.AttGroup).HasMaxLength(100);

                entity.Property(e => e.AttName).HasMaxLength(160);

                entity.Property(e => e.AttType).HasMaxLength(20);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.GlobalGlobalEntryAttrs)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__Global#Glob__RID__3647D946");
            });

            modelBuilder.Entity<GlobalGlobalEntryDetail>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Global#GlobalEntry#Detail");

                entity.HasIndex(e => new { e.Rid, e.ParentId }, "IDX_ParentID");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.NameDelete).HasMaxLength(255);

                entity.Property(e => e.NameEdit).HasMaxLength(255);

                entity.Property(e => e.NameInsert).HasMaxLength(255);

                entity.Property(e => e.NameJoin).HasMaxLength(255);

                entity.Property(e => e.NamePrebuild).HasMaxLength(255);

                entity.Property(e => e.NamePref).HasMaxLength(255);

                entity.Property(e => e.NameRead).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.GlobalGlobalEntryDetails)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Global#GlobalEntry#Detail_Global#GlobalEntry1");
            });

            modelBuilder.Entity<GlobalUserDictionary>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Global#UserDictionary");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Icon).HasColumnType("image");

                entity.Property(e => e.Mask).HasMaxLength(260);

                entity.Property(e => e.NType).HasColumnName("nType");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<GroupParamGroup>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__GroupPar__CAFF413247A4047C");

                entity.ToTable("GroupParam#Group");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.GroupParamGroups)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupPara__Catal__172F20A0");
            });

            modelBuilder.Entity<GroupParamParam>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__GroupPar__CAFF41321310E5AE");

                entity.ToTable("GroupParam#Param");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Formula).HasMaxLength(260);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupParamParams)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupPara__Group__182344D9");

                entity.HasOne(d => d.Param)
                    .WithMany(p => p.GroupParamParams)
                    .HasForeignKey(d => d.ParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupPara__Param__19176912");
            });

            modelBuilder.Entity<GroupWorkGroup>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__GroupWor__CAFF413298A299D0");

                entity.ToTable("GroupWork#Group");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.GroupWorkGroups)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupWork__Catal__11021155");
            });

            modelBuilder.Entity<GroupWorkWork>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__GroupWor__CAFF4132905C56D2");

                entity.ToTable("GroupWork#Work");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Formula).HasMaxLength(260);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupWorkWorks)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupWork__Group__14D2A239");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.GroupWorkWorks)
                    .HasForeignKey(d => d.WorkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupWork#Work_WorkID");
            });

            modelBuilder.Entity<HistoryState>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__History#__CAFF4132FB0122A6");

                entity.ToTable("History#State");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.StateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserName).HasMaxLength(260);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.HistoryStates)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK__History#S__Agent__1A0B8D4B");
            });

            modelBuilder.Entity<IntObligationIntObligation>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_InternationalObligation#InternationalObligation");

                entity.ToTable("IntObligation#IntObligation");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.InSum).HasColumnName("inSum");

                entity.Property(e => e.IsPlan).HasColumnName("isPlan");

                entity.Property(e => e.Num).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProgName).HasMaxLength(250);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkName).HasMaxLength(250);
            });

            modelBuilder.Entity<MessageMessage>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Message#__CAFF4132F948DFE8");

                entity.ToTable("Message#Message");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.MassageText).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.MessageMessages)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Message#M__Catal__1AFFB184");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.MessageMessages)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Message#M__TypeI__1BF3D5BD");
            });

            modelBuilder.Entity<MmWork>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("MM#Work");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.RankParam1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RankParam2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RankParam3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RankParam4).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.MmWorks)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work_CatalogID");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.MmWorks)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work_StageID");
            });

            modelBuilder.Entity<MmWorkGroup>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_MM#Work#Group_RID");

                entity.ToTable("MM#Work#Group");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.MmWorkGroups)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work#Group_CatalogID");
            });

            modelBuilder.Entity<MmWorkGroupPerson>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_MM_Work#Group#Person_RID");

                entity.ToTable("MM#Work#Group#Person");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.MmWorkGroupPeople)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work#Group#Person_GroupID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.MmWorkGroupPeople)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work#Group#Person_PersonID");
            });

            modelBuilder.Entity<MmWorkPerson>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("MM#Work#Person");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.MmWorkPeople)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work#Person_PersonID");

                entity.HasOne(d => d.Work)
                    .WithMany(p => p.MmWorkPeople)
                    .HasForeignKey(d => d.WorkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work#Person_WorkID");
            });

            modelBuilder.Entity<MmWorkPersonContribution>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("MM#Work#Person#Contribution");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CalcDate).HasColumnType("date");

                entity.Property(e => e.ContributionValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonRaiting).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.MmWorkPersonContributions)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work#Person#Contribution_PersonID");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.MmWorkPersonContributions)
                    .HasForeignKey(d => d.StageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work#Person#Contribution_StageID");
            });

            modelBuilder.Entity<MmWorkPersonParam>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("MM#Work#Person#Param");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.MmWorkPersonParams)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work#Person#Param_ManagerID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.MmWorkPersonParams)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MM#Work#Person#Param_ParentID");
            });

            modelBuilder.Entity<MmWorkStage>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("MM#Work#Stage");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);
            });

            modelBuilder.Entity<ObjectiveObjective>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Objective#Objective");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SystemName).HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.ObjectiveObjectives)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Objective#Objective_Version#Version");
            });

            modelBuilder.Entity<OrbitalGroupVariant>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("OrbitalGroup#Variant");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.OrbitalGroupVariants)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrbitalGroup#Variant_Version#Version");
            });

            modelBuilder.Entity<OrbitalGroupVariantDatum>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("OrbitalGroup#Variant#Data");

                entity.HasIndex(e => e.ParentId, "IDX_ParentID_RID");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.BoosterId).HasColumnName("BoosterID");

                entity.Property(e => e.BoosterIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("BoosterID_Code");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.ClassRnCode)
                    .HasMaxLength(50)
                    .HasColumnName("ClassRN_Code");

                entity.Property(e => e.ClassRnid).HasColumnName("ClassRNID");

                entity.Property(e => e.FactDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.FactDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.FlightModel)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ObtekatelId).HasColumnName("ObtekatelID");

                entity.Property(e => e.ObtekatelIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("ObtekatelID_Code");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.RocketId).HasColumnName("RocketID");

                entity.Property(e => e.RocketIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("RocketID_Code");

                entity.Property(e => e.SpaceLaunchId).HasColumnName("SpaceLaunchID");

                entity.Property(e => e.SpaceLaunchIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("SpaceLaunchID_Code");

                entity.Property(e => e.SpaceLaunchSetId).HasColumnName("SpaceLaunchSetID");

                entity.Property(e => e.SpaceLaunchSetIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("SpaceLaunchSetID_Code");

                entity.Property(e => e.SpaceSystemId).HasColumnName("SpaceSystemID");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.SpacecraftId).HasColumnName("SpacecraftID");

                entity.Property(e => e.SpacecraftIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("SpacecraftID_Code");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(50)
                    .HasColumnName("State_Code");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.OrbitalGroupVariantData)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrbitalGroup#Variant#Data_OrbitalGroup#Variant");
            });

            modelBuilder.Entity<OrbitalGroupVariantPlan>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("OrbitalGroup#Variant#Plan");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.CnidCode)
                    .HasMaxLength(260)
                    .HasColumnName("CNID_Code");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DictionaryId).HasColumnName("DictionaryID");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.OrbitalGroupVariantPlans)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrbitalGroup#Variant#Plan_OrbitalGroup#Variant");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Organization");

                entity.HasComment("Перечень организаций");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID")
                    .HasComment("Первичный ключ");

                entity.Property(e => e.AgentId)
                    .HasColumnName("AgentID")
                    .HasComment("Идентификатор контрагента");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasComment("Наименование");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("smalldatetime")
                    .HasComment("Период существования - начало");

                entity.Property(e => e.DateTo)
                    .HasColumnType("smalldatetime")
                    .HasComment("Период существования - окончание");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasComment("Примечание");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Organization_Agent#Agent");
            });

            modelBuilder.Entity<ParamParam>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Param#Pa__CAFF4132E116F59B");

                entity.ToTable("Param#Param");

                entity.HasIndex(e => new { e.Rid, e.ShortName }, "IDX_RID_ShortName");

                entity.HasIndex(e => e.ShortName, "_dta_index_Param#Param_5_160107711__K7");

                entity.HasIndex(e => new { e.ShortName, e.Rid, e.DataType }, "_dta_index_Param#Param_5_160107711__K7_K1_K8");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DataType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Formula).HasMaxLength(260);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.LinkFieldId).HasColumnName("LinkFieldID");

                entity.Property(e => e.LinkSectionId).HasColumnName("LinkSectionID");

                entity.Property(e => e.LinkType).HasDefaultValueSql("((0))");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcedureId).HasColumnName("ProcedureID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.ParamParams)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Param#Par__Catal__1ED04268");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ParamParams)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Param#Param_Group");

                entity.HasOne(d => d.Measure)
                    .WithMany(p => p.ParamParams)
                    .HasForeignKey(d => d.MeasureId)
                    .HasConstraintName("FK__Param#Par__Measu__1DDC1E2F");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ParamParams)
                    .HasForeignKey(d => d.ProcedureId)
                    .HasConstraintName("FK__Param#Par__Proce__1FC466A1");
            });

            modelBuilder.Entity<ParamValue>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Param#Value");

                entity.HasIndex(e => new { e.ParamId, e.Rid }, "IDX_ParamValue");

                entity.HasIndex(e => e.VersionId, "IX_Param#Value_VersionID");

                entity.HasIndex(e => new { e.ParamId, e.Rid }, "_dta_index_Param#Value_5_599777294__K2_K1_5_6_7_10");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.LinkText).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ValueD1).HasColumnType("smalldatetime");

                entity.Property(e => e.ValueD2).HasColumnType("smalldatetime");

                entity.Property(e => e.ValueN1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValueN2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.ParamValues)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK__Param#Val__Versi__20B88ADA");
            });

            modelBuilder.Entity<ParamValueResult>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Param#Value#Result");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Note1).HasMaxLength(2000);

                entity.Property(e => e.Note2).HasMaxLength(2000);

                entity.Property(e => e.Note3).HasMaxLength(2000);

                entity.Property(e => e.ResultValueId).HasColumnName("ResultValueID");

                entity.Property(e => e.VariantDateFrom1).HasColumnType("date");

                entity.Property(e => e.VariantDateFrom2).HasColumnType("date");

                entity.Property(e => e.VariantDateFrom3).HasColumnType("date");

                entity.Property(e => e.VariantDateTo1).HasColumnType("date");

                entity.Property(e => e.VariantDateTo2).HasColumnType("date");

                entity.Property(e => e.VariantDateTo3).HasColumnType("date");

                entity.Property(e => e.VariantValue1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VariantValue2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VariantValue3).HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.ResultValue)
                    .WithMany(p => p.ParamValueResults)
                    .HasForeignKey(d => d.ResultValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Param#Value#Result_Task#Result#Value");
            });

            modelBuilder.Entity<PostDuty>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Post#Dut__CAFF4132F128D2C3");

                entity.ToTable("Post#Duty");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostDuties)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Post#Duty__PostI__21ACAF13");
            });

            modelBuilder.Entity<PostPost>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Post#Pos__CAFF4132F8BDE182");

                entity.ToTable("Post#Post");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.PostPosts)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Post#Post__Catal__22A0D34C");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PostPosts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Post#Post__Categ__24891BBE");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PostPosts)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Post#Post__Depar__2394F785");
            });

            modelBuilder.Entity<PriorityCriterionObject>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("PriorityCriterion#Object");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_RID");

                entity.HasIndex(e => new { e.ObjectId, e.Rid, e.CriterionId }, "_dta_index_PriorityCriterion#Object_10_803638056__K2_K1_K3_8");

                entity.HasIndex(e => new { e.ObjectId, e.VersionId }, "missing_index_20046_20045_PriorityCriterion#Object");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CalcDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CriterionId).HasColumnName("CriterionID");

                entity.Property(e => e.CriterionValue).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ParamValue).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.ValueN1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValueN2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValueN3).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Criterion)
                    .WithMany(p => p.PriorityCriterionObjects)
                    .HasForeignKey(d => d.CriterionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriorityCriterion#Object_Criterion");

                entity.HasOne(d => d.Object)
                    .WithMany(p => p.PriorityCriterionObjects)
                    .HasForeignKey(d => d.ObjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriorityCriterion#Object_Project");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.PriorityCriterionObjects)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriorityCriterion#Object_Version");
            });

            modelBuilder.Entity<PriorityCriterionRank>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("PriorityCriterion#Rank");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_RID");

                entity.HasIndex(e => new { e.Criterion1Id, e.Criterion2Id, e.RankValue, e.PersonId }, "UDX_Cr1_Cr2_Rank_Person");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Criterion1Id).HasColumnName("Criterion1ID");

                entity.Property(e => e.Criterion2Id).HasColumnName("Criterion2ID");

                entity.Property(e => e.NRankValue).HasColumnName("nRankValue");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.RankDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RankValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PriorityCriterionRanks)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriorityCriterion#Rank_Person");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.PriorityCriterionRanks)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_PriorityCriterion#Rank_Version");
            });

            modelBuilder.Entity<PriorityCriterionScale>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("PriorityCriterion#Scale");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CriterionId).HasColumnName("CriterionID");

                entity.Property(e => e.CriterionValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamValueFrom).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ParamValueTo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ScaleName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.HasOne(d => d.Criterion)
                    .WithMany(p => p.PriorityCriterionScales)
                    .HasForeignKey(d => d.CriterionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriorityCriterion#Scale_Criterion");
            });

            modelBuilder.Entity<PriorityCriterionValue>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("PriorityCriterion#Value");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CriterionId).HasColumnName("CriterionID");

                entity.Property(e => e.CriterionValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamValue).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.Criterion)
                    .WithMany(p => p.PriorityCriterionValues)
                    .HasForeignKey(d => d.CriterionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriorityCriterion#Value_CriterionID");
            });

            modelBuilder.Entity<ProjectPlanFinDistribution>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Project#PlanFin#Distribution");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.PlanVersionId).HasColumnName("PlanVersionID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Sum1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Sum10).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Sum2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Sum3).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Sum4).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Sum5).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Sum6).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Sum7).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Sum8).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Sum9).HasColumnType("numeric(18, 4)");

                entity.HasOne(d => d.PlanVersion)
                    .WithMany(p => p.ProjectPlanFinDistributions)
                    .HasForeignKey(d => d.PlanVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project#PlanFin#Distribution#Version");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectPlanFinDistributions)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project#PlanFin#Distribution#Project");
            });

            modelBuilder.Entity<ProjectProject>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Project#Project");

                entity.HasIndex(e => e.VersionId, "IDX_Project#Project_10_1877021868__K13_1");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID");

                entity.HasIndex(e => new { e.VersionId, e.Code }, "IDX_VersionID_Code");

                entity.HasIndex(e => new { e.VersionId, e.Rid, e.TypeId, e.Num, e.Code }, "_dta_index_Project#Project_10_1877021868__K13_K1_K12_K3_K4_5_6_7_8_9_10_11_14_16");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.AllowableSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BaseRank).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.LaborCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority3).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.SystemName).HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.ProjectProjects)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Project#Project_Version#Version");
            });

            modelBuilder.Entity<ProjectUser>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Project#User");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectUsers)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project#User_Project#Project");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project#User_System#User");
            });

            modelBuilder.Entity<PurposePurpose>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Purpose#Purpose");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SystemName).HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Purpose#Purpose_Purpose#Purpose");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.PurposePurposes)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Purpose#Purpose_Version#Version");
            });

            modelBuilder.Entity<RiskDamageValue>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Risk#Damage#Value");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<RiskEvent>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Risk#Event");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.BaseEvent).HasMaxLength(2000);

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryRiskId).HasColumnName("DictionaryRiskID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.RiskEvents)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Risk#Event_Catalog");

                entity.HasOne(d => d.DictionaryRisk)
                    .WithMany(p => p.RiskEvents)
                    .HasForeignKey(d => d.DictionaryRiskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Risk#Event_DictionaryRisk");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.RiskEvents)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Risk#Event_Version");
            });

            modelBuilder.Entity<RiskEventProbabilityValue>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Risk#Event#Probability#Value");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<RiskEventValue>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Risk#Event#Value");

                entity.HasIndex(e => e.DictionaryWorkRiskEventId, "IDX_DWRiskEvent");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.DamageValueR).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DamageValueS).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DamageValueT).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DictionaryWorkRiskEventId).HasColumnName("DictionaryWorkRiskEventID");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ValueP).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.DictionaryWorkRiskEvent)
                    .WithMany(p => p.RiskEventValues)
                    .HasForeignKey(d => d.DictionaryWorkRiskEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Risk#Event#Value_DictionaryWorkRiskEvent");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.RiskEventValues)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Risk#Event#Value_Person");
            });

            modelBuilder.Entity<RiskPriority>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Risk#Priority");

                entity.HasIndex(e => new { e.VersionId, e.DictionaryWorkId }, "_dta_index_Risk#Priority_5_1682261198__K3_K2_6_7_8_10_11_12");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.DictionaryWorkId).HasColumnName("DictionaryWorkID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.R11).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R12).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R13).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R21).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R22).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R23).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R31).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R32).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R33).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.RiskPriorities)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Risk#Priority_Version");
            });

            modelBuilder.Entity<ScenarioHistory>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Scenario__CAFF4132E9BC3269");

                entity.ToTable("Scenario#History");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ExecDate).HasColumnType("datetime");

                entity.Property(e => e.ScenarioStageId).HasColumnName("ScenarioStageID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserName).HasMaxLength(260);

                entity.HasOne(d => d.ScenarioStage)
                    .WithMany(p => p.ScenarioHistories)
                    .HasForeignKey(d => d.ScenarioStageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Scenario#__Scena__26716430");
            });

            modelBuilder.Entity<ScenarioMessage>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Scenario__CAFF4132014A82E4");

                entity.ToTable("Scenario#Message");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.MessageTypeId).HasColumnName("MessageTypeID");

                entity.Property(e => e.ScenarioStageId).HasColumnName("ScenarioStageID");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.ScenarioMessages)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Scenario#__Messa__2859ACA2");

                entity.HasOne(d => d.MessageType)
                    .WithMany(p => p.ScenarioMessages)
                    .HasForeignKey(d => d.MessageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Scenario#__Messa__294DD0DB");

                entity.HasOne(d => d.ScenarioStage)
                    .WithMany(p => p.ScenarioMessages)
                    .HasForeignKey(d => d.ScenarioStageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Scenario#__Scena__27658869");
            });

            modelBuilder.Entity<ScenarioScenario>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Scenario__CAFF41321125943A");

                entity.ToTable("Scenario#Scenario");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.ScenarioScenarios)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Scenario#__Catal__2A41F514");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ScenarioScenarios)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Scenario#__TypeI__2B36194D");
            });

            modelBuilder.Entity<ScenarioStage>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Scenario__CAFF4132229A6C12");

                entity.ToTable("Scenario#Stage");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ResultTypeId).HasColumnName("ResultTypeID");

                entity.Property(e => e.ResultValue).HasMaxLength(260);

                entity.Property(e => e.ScenarioId).HasColumnName("ScenarioID");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.ScenarioStages)
                    .HasForeignKey(d => d.AgentId)
                    .HasConstraintName("FK__Scenario#__Agent__2D1E61BF");

                entity.HasOne(d => d.Scenario)
                    .WithMany(p => p.ScenarioStages)
                    .HasForeignKey(d => d.ScenarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Scenario#__Scena__2C2A3D86");
            });

            modelBuilder.Entity<SchedulerAppointment>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Scheduler#Appointment");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsPrivate).HasColumnName("isPrivate");

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(50)
                    .HasColumnName("OwnerID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SchedulerDependency>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Scheduler#Dependencies");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.DependentId).HasColumnName("DependentID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<SelectList>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("SelectList");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.Entry)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(user_name())");
            });

            modelBuilder.Entity<SpaceLaunchSet>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("SpaceLaunch#Set");

                entity.HasIndex(e => new { e.Rid, e.RnRid, e.RbRid, e.ObRid, e.VersionId, e.SlRid }, "IDX_AllField");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_RID");

                entity.HasIndex(e => e.ObRid, "_dta_index_SpaceLaunch#Set_5_1458924369__K6_7");

                entity.HasIndex(e => new { e.VersionId, e.Rid, e.SlRid, e.RnRid, e.RbRid, e.ObRid }, "_dta_index_SpaceLaunch#Set_5_1458924369__K7_K1_K9_K4_K5_K6_2");

                entity.HasIndex(e => new { e.VersionId, e.RbRid, e.Rid, e.RnRid }, "_dta_index_SpaceLaunch#Set_5_1458924369__K7_K5_K1_K4");

                entity.HasIndex(e => new { e.VersionId, e.RbRid, e.ObRid, e.Rid }, "_dta_index_SpaceLaunch#Set_5_1458924369__K7_K5_K6_K1");

                entity.HasIndex(e => new { e.VersionId, e.ObRid, e.Rid, e.RnRid, e.RbRid }, "_dta_index_SpaceLaunch#Set_5_1458924369__K7_K6_K1_K4_K5");

                entity.HasIndex(e => new { e.VersionId, e.ObRid, e.Rid, e.RnRid, e.SlRid, e.RbRid }, "_dta_index_SpaceLaunch#Set_5_1458924369__K7_K6_K1_K4_K9_K5_2_3_8");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ObRid).HasColumnName("ObRID");

                entity.Property(e => e.RbRid).HasColumnName("RbRID");

                entity.Property(e => e.RnRid).HasColumnName("RnRID");

                entity.Property(e => e.SlRid).HasColumnName("SlRID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.SpaceLaunchSets)
                    .HasForeignKey(d => d.CatalogId)
                    .HasConstraintName("FK_SpaceLaunch#Set_Catalog#Catalog");
            });

            modelBuilder.Entity<SpaceLaunchSetSpec>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("SpaceLaunch#Set#Spec");

                entity.HasIndex(e => e.ParentId, "IDX_ParentID_RID");

                entity.HasIndex(e => new { e.KaRid, e.ParentId }, "_dta_index_SpaceLaunch#Set#Spec_5_290920208__K3_K2");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.KaRid).HasColumnName("KaRID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.KaR)
                    .WithMany(p => p.SpaceLaunchSetSpecs)
                    .HasForeignKey(d => d.KaRid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpaceLaunch#Set#Spec_KaRID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.SpaceLaunchSetSpecs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpaceLaunch#Set#Spec_SpaceLaunch#Set");
            });

            modelBuilder.Entity<SpacePolicyObjective>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("SpacePolicy#Objective");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<SpacePolicyObjectiveDirection>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("SpacePolicy#Objective#Direction");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkDirectionId).HasColumnName("WorkDirectionID");

                entity.HasOne(d => d.Objective)
                    .WithMany(p => p.SpacePolicyObjectiveDirections)
                    .HasForeignKey(d => d.ObjectiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpacePolicy#Objective#Direction_ObjectiveID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.SpacePolicyObjectiveDirections)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpacePolicy#Objective#Direction_VersionID");

                entity.HasOne(d => d.WorkDirection)
                    .WithMany(p => p.SpacePolicyObjectiveDirections)
                    .HasForeignKey(d => d.WorkDirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpacePolicy#Objective#Direction_WorkDirectionID");
            });

            modelBuilder.Entity<SpacePolicyObjectiveObjective>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("SpacePolicy#Objective#Objective");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Objective)
                    .WithMany(p => p.SpacePolicyObjectiveObjectives)
                    .HasForeignKey(d => d.ObjectiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpacePolicy#Objective#Objective_ObjectiveID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.SpacePolicyObjectiveObjectives)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpacePolicy#Objective#Objective_ParentID");
            });

            modelBuilder.Entity<SpaceSystemSpaceSystem>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_Space#System");

                entity.ToTable("SpaceSystem#SpaceSystem");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.HasOne(d => d.Cn)
                    .WithMany(p => p.SpaceSystemSpaceSystems)
                    .HasForeignKey(d => d.Cnid)
                    .HasConstraintName("FK_SpaceSystem_DictionaryDictionary");
            });

            modelBuilder.Entity<SpacecraftSpacecraft>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_Spacecraft#Spacecraft_RID");

                entity.ToTable("Spacecraft#Spacecraft");

                entity.HasIndex(e => new { e.Rid, e.VersionId, e.SpaceLaunchSetId }, "IDX_RID_Version_Date");

                entity.HasIndex(e => e.SpaceLaunchSetId, "IDX_SpaceLaunchSetID");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_SpecacraftID_PlanDateFrom");

                entity.HasIndex(e => e.PlanDateFrom, "IDX_Version_Specraft_Plan_Fact");

                entity.HasIndex(e => new { e.VersionId, e.PlanDateFrom }, "NonClusteredIndex-20201105-114559");

                entity.HasIndex(e => new { e.VersionId, e.PlanDateFrom }, "NonClusteredIndex-20201105-114754");

                entity.HasIndex(e => new { e.VersionId, e.Rid, e.PlanDateFrom, e.SpaceLaunchSetId }, "_dta_index_Spacecraft#Spacecraft_5_850922203__K2_K1_K7_K14");

                entity.HasIndex(e => new { e.VersionId, e.FactDateFrom, e.State, e.SpacecraftId, e.SpaceLaunchSetId, e.Rid, e.PlanDateFrom }, "_dta_index_Spacecraft#Spacecraft_5_850922203__K2_K9_K12_K3_K14_K1_K7_10_11_13");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.BoosterId).HasColumnName("BoosterID");

                entity.Property(e => e.FactDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.FactDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.RocketId).HasColumnName("RocketID");

                entity.Property(e => e.SpaceLaunchId).HasColumnName("SpaceLaunchID");

                entity.Property(e => e.SpaceLaunchSetId).HasColumnName("SpaceLaunchSetID");

                entity.Property(e => e.SpacecraftId).HasColumnName("SpacecraftID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Booster)
                    .WithMany(p => p.SpacecraftSpacecraftBoosters)
                    .HasForeignKey(d => d.BoosterId)
                    .HasConstraintName("FK_Spacecraft#Spacecraft_Booster");

                entity.HasOne(d => d.Rocket)
                    .WithMany(p => p.SpacecraftSpacecraftRockets)
                    .HasForeignKey(d => d.RocketId)
                    .HasConstraintName("FK_Spacecraft#Spacecraft_Rocket");

                entity.HasOne(d => d.SpaceLaunch)
                    .WithMany(p => p.SpacecraftSpacecrafts)
                    .HasForeignKey(d => d.SpaceLaunchId)
                    .HasConstraintName("FK_Spacecraft#Spacecraft_SpaceLaunch");

                entity.HasOne(d => d.SpaceLaunchSet)
                    .WithMany(p => p.SpacecraftSpacecrafts)
                    .HasForeignKey(d => d.SpaceLaunchSetId)
                    .HasConstraintName("FK_Spacecraft#Spacecraft_VersionSpaceLaunchSet");

                entity.HasOne(d => d.Spacecraft)
                    .WithMany(p => p.SpacecraftSpacecraftSpacecrafts)
                    .HasForeignKey(d => d.SpacecraftId)
                    .HasConstraintName("FK_Spacecraft#Spacecraft_Spacecraft");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.SpacecraftSpacecrafts)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Spacecraft#Spacecraft_Version");
            });

            modelBuilder.Entity<SpaceportCoordinate>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Spaceport#Coordinate");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Lantitude).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Longtitude).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<StageStage>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Stage#Stage");

                entity.HasIndex(e => new { e.VersionId, e.WorkType }, "IDX_Stage#Stage_All");

                entity.HasIndex(e => new { e.VersionId, e.WorkType }, "IDX_Version_WorkType");

                entity.HasIndex(e => e.WorkType, "IDX_WT_RID_DWID_VER_STAGETYPE");

                entity.HasIndex(e => e.WorkType, "IDX_WorkType_RID_DWID_Parent_Version_Code_Name");

                entity.HasIndex(e => new { e.ParentId, e.Rid }, "_dta_index_Stage#Stage_5_1929266128__K3_K1");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.DictionaryWorkId).HasColumnName("DictionaryWorkID");

                entity.Property(e => e.Gostid).HasColumnName("GOSTID");

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StagePercent).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StageTypeId).HasColumnName("StageTypeID");

                entity.Property(e => e.StageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCategoryId).HasColumnName("WorkCategoryID");

                entity.HasOne(d => d.DictionaryWork)
                    .WithMany(p => p.StageStages)
                    .HasForeignKey(d => d.DictionaryWorkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stage#Stage_DictionaryWorkID");

                entity.HasOne(d => d.Gost)
                    .WithMany(p => p.StageStageGosts)
                    .HasForeignKey(d => d.Gostid)
                    .HasConstraintName("FK_Stage#Stage_GOSTID");

                entity.HasOne(d => d.Kind)
                    .WithMany(p => p.StageStageKinds)
                    .HasForeignKey(d => d.KindId)
                    .HasConstraintName("FK_Stage#Stage_KindID");

                entity.HasOne(d => d.StageType)
                    .WithMany(p => p.StageStages)
                    .HasForeignKey(d => d.StageTypeId)
                    .HasConstraintName("FK_Stage#Stage_StageTypeID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.StageStages)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stage#Stage_VersionID");

                entity.HasOne(d => d.WorkCategory)
                    .WithMany(p => p.StageStageWorkCategories)
                    .HasForeignKey(d => d.WorkCategoryId)
                    .HasConstraintName("FK_Stage#Stage_WorkCategoryID");
            });

            modelBuilder.Entity<StructureAgentGroup>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Structure#AgentGroup");

                entity.HasIndex(e => new { e.Rid, e.StructureId, e.AgentGroupId }, "IDX_RID_StructureID_AgentGroupID");

                entity.HasIndex(e => e.StructureId, "IDX_StructureID_AgentGroupID");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.AgentGroupId).HasColumnName("AgentGroupID");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.StructureId).HasColumnName("StructureID");

                entity.HasOne(d => d.AgentGroup)
                    .WithMany(p => p.StructureAgentGroups)
                    .HasForeignKey(d => d.AgentGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Structure#AgentGroup_Group");

                entity.HasOne(d => d.Structure)
                    .WithMany(p => p.StructureAgentGroups)
                    .HasForeignKey(d => d.StructureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Structure#AgentGroup_Structure");
            });

            modelBuilder.Entity<StructureElement>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Structure#Element");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Structure#Element_Parent");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.StructureElements)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Structure#Element_Type");
            });

            modelBuilder.Entity<StructureParam>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Structure#Param");

                entity.HasIndex(e => e.IsActual, "IDX_Actual_Parent_Param_Year_Value_Version_Person");

                entity.HasIndex(e => new { e.ParamId, e.IsActual }, "IDX_Param_Actual_Parent_CalcDate_Version");

                entity.HasIndex(e => new { e.ParentId, e.IsActual, e.VersionId }, "IDX_ParentID_Actual_Version");

                entity.HasIndex(e => new { e.Rid, e.Value }, "IDX_Structure#Param_10_1690593211__K1_K6");

                entity.HasIndex(e => new { e.ParentId, e.VersionId, e.Rid, e.ParamId, e.CalcDate }, "IDX_Structure#Param_10_1690593211__K2_K10_K1_K3_K4");

                entity.HasIndex(e => new { e.VersionId, e.IsActual, e.ParentId, e.ParamId }, "_dta_index_Structure#Param_5_1690593211__K10_K9_K2_K3_4");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CalcDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActual)
                    .HasColumnName("isActual")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsBasic)
                    .HasColumnName("isBasic")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsManual)
                    .HasColumnName("isManual")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Param)
                    .WithMany(p => p.StructureParams)
                    .HasForeignKey(d => d.ParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Structure#Param_ParamID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.StructureParams)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Structure#Param_PersonID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.StructureParams)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Structure#Param_VersionID");
            });

            modelBuilder.Entity<StructureStructure>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Structure#Structure");

                entity.HasIndex(e => new { e.ElementId, e.VersionId }, "IDX_ElementID_VersionID_RID");

                entity.HasIndex(e => e.VersionId, "IDX_RID_Parent_Element_Type");

                entity.HasIndex(e => e.ElementType, "IDX_Structure#Structure_ElementType_ParentID_ElementID");

                entity.HasIndex(e => new { e.ElementId, e.VersionId, e.Rid, e.ParentId, e.ElementType }, "_dta_index_Structure#Structure_10_1465160365__K3_K5_K1_K2_K6");

                entity.HasIndex(e => e.ParentId, "index_131_130_Structure#Structure");

                entity.HasIndex(e => e.ElementType, "missing_index_20033_20032_Structure#Structure");

                entity.HasIndex(e => e.ElementType, "missing_index_20035_20034_Structure#Structure");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Structure#Structure_Parent");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.StructureStructures)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Structure#Structure_Version");
            });

            modelBuilder.Entity<StructureStructureGetWorkGanttDependenceTemp>(entity =>
            {
                entity.HasKey(e => e.Mainid);

                entity.ToTable("Structure#Structure#GetWorkGanttDependence#Temp");

                entity.Property(e => e.Mainid)
                    .HasColumnName("MAINID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Keyid)
                    .HasColumnName("KEYID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.NType).HasColumnName("nType");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(user_name())");
            });

            modelBuilder.Entity<StructureStructureGetWorkGanttResourceTemp>(entity =>
            {
                entity.HasKey(e => e.MainRid);

                entity.ToTable("Structure#Structure#GetWorkGanttResource#Temp");

                entity.Property(e => e.MainRid)
                    .HasColumnName("MainRID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.KindIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("KindID_Code");

                entity.Property(e => e.NType).HasColumnName("nType");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StageSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StageSumEdit).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Summ).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SummEdit).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UserName).HasMaxLength(128);
            });

            modelBuilder.Entity<StructureStructureGetWorkGanttSession>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Structure#Structure#GetWorkGantt#Session");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateBegin)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.OwnerUserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<StructureStructureGetWorkGanttTemp>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Structure#Structure#GetWorkGantt#Temp");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.EventTypeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.ParentDictionaryWorkId).HasColumnName("ParentDictionaryWorkID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ShortName).HasMaxLength(4000);

                entity.Property(e => e.StageSum).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Summ).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.TypeStructElement).HasMaxLength(4000);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<SystemAdminUpdateInfo>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#Admin#Update#Info");

                entity.HasComment("Журнал обновлений системы");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID")
                    .HasComment("Первичный ключ");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasComment("Примечание");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата обновления");

                entity.Property(e => e.UpdatePackageName)
                    .HasMaxLength(255)
                    .HasComment("Имя пакета обновления");

                entity.Property(e => e.UpdateState).HasComment("Состояние обновления");

                entity.Property(e => e.UpdateVersion)
                    .HasMaxLength(50)
                    .HasComment("Версия системы");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasComment("Имя пользователя");
            });

            modelBuilder.Entity<SystemAdminUpdateInfoSpec>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_System#Update#Admin#Info#Spec");

                entity.ToTable("System#Admin#Update#Info#Spec");

                entity.HasComment("Спецификация журнала обновлений системы");

                entity.HasIndex(e => e.ParentId, "missing_index_20028_20027_System#Admin#Update#Info#Spec");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID")
                    .HasComment("Первичный ключ");

                entity.Property(e => e.DateBegin)
                    .HasColumnType("datetime")
                    .HasComment("Время начала обновления");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("datetime")
                    .HasComment("Время окончания обновления");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasComment("Описание выполняемых операций");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Имя файла");

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .HasComment("Примечание");

                entity.Property(e => e.OldObjectScript).HasComment("Скрипт изменяемого объекта базы данных");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasComment("Идентификатор записи в журнале обновления");

                entity.Property(e => e.State).HasComment("Состояние обновления");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.SystemAdminUpdateInfoSpecs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Admin#Update#Info#Spec_System#Admin#Update#Info");
            });

            modelBuilder.Entity<SystemAlert>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#Alert");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IsActual).HasColumnName("isActual");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ShowBefore).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<SystemAudit>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#Audit");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ChangeTime).HasColumnType("datetime");

                entity.Property(e => e.ChangeType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.NewValue).HasColumnType("xml");

                entity.Property(e => e.OldValue).HasColumnType("xml");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserRid).HasColumnName("UserRID");
            });

            modelBuilder.Entity<SystemAuditLog>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#AuditLog");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.CallParams).HasMaxLength(2000);

                entity.Property(e => e.CallProcedure)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SessionID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(260);
            });

            modelBuilder.Entity<SystemBackup>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#Backup");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID")
                    .HasComment("Первичный ключ");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasComment("Время создания резервной копии");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasComment("Наименование резервной копии");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasComment("Путь к файлу резервной копии");
            });

            modelBuilder.Entity<SystemCopyHelper>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#CopyHelper");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.NewIdfkp).HasColumnName("NewIDFKP");

                entity.Property(e => e.NewIdstruct).HasColumnName("NewIDStruct");

                entity.Property(e => e.OldIdfkp).HasColumnName("OldIDFKP");

                entity.Property(e => e.OldIdstruct).HasColumnName("OldIDStruct");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");
            });

            modelBuilder.Entity<SystemErrorLog>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#ErrorLog");

                entity.HasIndex(e => new { e.Rid, e.Date }, "IDX_Date");

                entity.HasIndex(e => e.Rid, "_dta_index_System#ErrorLog_10_1052634893__K1_5");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ErrorDescription).HasMaxLength(2000);

                entity.Property(e => e.ErrorSystemDescription).HasMaxLength(2000);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcName).HasMaxLength(250);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(260);
            });

            modelBuilder.Entity<SystemIssue>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_System#Issue_RID");

                entity.ToTable("System#Issue");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.DateNotifyExecutor).HasColumnType("datetime");

                entity.Property(e => e.ErrorId).HasColumnName("ErrorID");

                entity.Property(e => e.Executor).HasMaxLength(250);

                entity.Property(e => e.ExternalNumber).HasMaxLength(50);

                entity.Property(e => e.FactDateAccept).HasColumnType("datetime");

                entity.Property(e => e.FactDateExecution).HasColumnType("datetime");

                entity.Property(e => e.Issue).IsRequired();

                entity.Property(e => e.LinkDocs).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PlannedPeriod).HasColumnType("datetime");

                entity.Property(e => e.PriorityId).HasColumnName("PriorityID");

                entity.Property(e => e.Screenshot).HasColumnType("image");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.SystemIssues)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Issue_CatalogID");

                entity.HasOne(d => d.Error)
                    .WithMany(p => p.SystemIssues)
                    .HasForeignKey(d => d.ErrorId)
                    .HasConstraintName("FK_System#Issue_ErrorID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.SystemIssues)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Issue_PersonID");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SystemIssues)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_System#Issue_SectionID");
            });

            modelBuilder.Entity<SystemIssueHistory>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_System#Issue#History_RID");

                entity.ToTable("System#Issue#History");

                entity.HasIndex(e => new { e.ParentId, e.StateDate }, "_dta_index_System#Issue#History_10_542117172__K2_K4");

                entity.HasIndex(e => new { e.StateDate, e.ParentId, e.StateId }, "_dta_index_System#Issue#History_10_542117172__K4_K2_K3");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.StateDate).HasColumnType("datetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.SystemIssueHistories)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Issue#History_ParentID");
            });

            modelBuilder.Entity<SystemLicense>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#License");

                entity.HasComment("Сведения о лицензиях");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("datetime")
                    .HasComment("Действителен до");

                entity.Property(e => e.FileData)
                    .IsRequired()
                    .HasColumnType("image")
                    .HasComment("Двоичные данные файла лицензии");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasComment("Имя файла лицензии");

                entity.Property(e => e.OrganizationId)
                    .HasColumnName("OrganizationID")
                    .HasComment("Идентификатор лицензируемой организации");

                entity.Property(e => e.UploadDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата загрузки");

                entity.Property(e => e.WorkPlaceCount).HasComment("Количество рабочих мест");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.SystemLicenses)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_System#License_Organization");
            });

            modelBuilder.Entity<SystemRole>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#Role");

                entity.HasComment("Справочник ролей");

                entity.HasIndex(e => e.Rid, "IDX_RID_Name");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);
            });

            modelBuilder.Entity<SystemRolePermissionAction>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ActionId });

                entity.ToTable("System#Role#Permission#Action");

                entity.HasComment("Права доступа ролей к действиям");

                entity.HasIndex(e => e.RoleId, "IX_System#Role#Permission#Action#RoleID");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("Идентификатор роли");

                entity.Property(e => e.ActionId)
                    .HasColumnName("ActionID")
                    .HasComment("Идентификатор действия");

                entity.Property(e => e.Audit)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("Признак ведения аудита действий");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.SystemRolePermissionActions)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Role#Permission#Action_System#Role");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SystemRolePermissionActions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Role#Permission#Action_System#Role1");
            });

            modelBuilder.Entity<SystemRolePermissionActionCatalog>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ActionId, e.CatalogId });

                entity.ToTable("System#Role#Permission#Action#Catalog");

                entity.HasComment("Права доступа ролей к действиям в разрезе каталогов");

                entity.HasIndex(e => new { e.RoleId, e.CatalogId }, "IX_System#Role#Permission#Action#Catalog#RoleID");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("Идентификатор роли");

                entity.Property(e => e.ActionId)
                    .HasColumnName("ActionID")
                    .HasComment("Идентификатор действия");

                entity.Property(e => e.CatalogId)
                    .HasColumnName("CatalogID")
                    .HasComment("Идентификатор каталога");

                entity.Property(e => e.Audit)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("Признак ведения аудита действий");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.SystemRolePermissionActionCatalogs)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Role#Permission#Action#Catalog_Global#GlobalEntryAttr");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.SystemRolePermissionActionCatalogs)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Role#Permission#Action#Catalog_Catalog#Catalog");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SystemRolePermissionActionCatalogs)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Role#Permission#Action#Catalog_System#Role");
            });

            modelBuilder.Entity<SystemRolePermissionColumn>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ColumnId });

                entity.ToTable("System#Role#Permission#Column");

                entity.HasComment("Права доступа ролей к столбцам");

                entity.HasIndex(e => e.RoleId, "IX_System#Role#Permission#Column#RoleID");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("Идентификатор роли");

                entity.Property(e => e.ColumnId)
                    .HasColumnName("ColumnID")
                    .HasComment("Идентификатор столбца");

                entity.Property(e => e.Editable).HasComment("Признак редактируемого столбца");

                entity.HasOne(d => d.Column)
                    .WithMany(p => p.SystemRolePermissionColumns)
                    .HasForeignKey(d => d.ColumnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Role#Permission#Column_Global#GlobalEntryAttr");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SystemRolePermissionColumns)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Role#Permission#Column_System#Role");
            });

            modelBuilder.Entity<SystemRolePermissionEntry>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.EntryId });

                entity.ToTable("System#Role#Permission#Entry");

                entity.HasComment("Права доступа ролей к разделам");

                entity.HasIndex(e => e.RoleId, "IX_System#Role#Permission#Entry#RoleID");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasComment("Идентификатор роли");

                entity.Property(e => e.EntryId)
                    .HasColumnName("EntryID")
                    .HasComment("Идентификатор раздела");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.SystemRolePermissionEntries)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Role#Permission#Entry_Global#GlobalEntry");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SystemRolePermissionEntries)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#Role#Permission#Entry_System#Role");
            });

            modelBuilder.Entity<SystemRoleUser>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#Role#User");

                entity.HasComment("Связь ролей с пользователями");

                entity.HasIndex(e => e.Rid, "IDX_RID_RolID_UserID");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SystemRoleUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_System#Role#User_System#Role#User");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemRoleUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_System#Role#User_System#User");
            });

            modelBuilder.Entity<SystemSession>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#Session");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.IsNormal)
                    .HasColumnName("isNormal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastActionTime).HasColumnType("datetime");

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.PrevActionTime).HasColumnType("datetime");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#Setting");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.BValue).HasColumnName("bValue");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DValue)
                    .HasColumnType("date")
                    .HasColumnName("dValue");

                entity.Property(e => e.GValue).HasColumnName("gValue");

                entity.Property(e => e.IsGlobal).HasColumnName("isGlobal");

                entity.Property(e => e.NType).HasColumnName("nType");

                entity.Property(e => e.NValue)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("nValue");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SValue)
                    .HasMaxLength(500)
                    .HasColumnName("sValue");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<SystemUpdateApp>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#Update#App");

                entity.HasComment("Таблица для хранения двоичных данных модулей системы");

                entity.HasIndex(e => e.FileName, "IX_System#Update#App#FileName")
                    .IsUnique();

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.FileData)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileVersion).HasMaxLength(255);

                entity.Property(e => e.HashSum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RelPath)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SystemUpdateAppLog>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#Update#AppLog");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.DateLog)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ResultMsg).HasMaxLength(4000);

                entity.Property(e => e.UserName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("(user_name())");
            });

            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#User");

                entity.HasComment("Пользователи приложения");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.BlockDate).HasColumnType("date");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(260);

                entity.Property(e => e.IsBlock)
                    .HasColumnName("isBlock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.SqluserId).HasColumnName("SQLUserID");

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.SystemUsers)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User_Agent#Agent");
            });

            modelBuilder.Entity<SystemUserOrganization>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.OrganizationId });

                entity.ToTable("System#User#Organization");

                entity.HasComment("Связь пользователей с организациями");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("Идентификатор пользователя");

                entity.Property(e => e.OrganizationId)
                    .HasColumnName("OrganizationID")
                    .HasComment("Идентификатор организации");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.SystemUserOrganizations)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Organization_Organization");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemUserOrganizations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Organization_System#User");
            });

            modelBuilder.Entity<SystemUserPermissionAction>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#User#Permission#Action");

                entity.HasComment("Права доступа пользователей к действиям");

                entity.HasIndex(e => e.UserId, "IX_System#User#Permission#Action#UserID");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActionId)
                    .HasColumnName("ActionID")
                    .HasComment("Идентификатор действия");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("Идентификатор пользователя");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.SystemUserPermissionActions)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Permission#Action_System#User");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemUserPermissionActions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Permission#Action_System#Role1");
            });

            modelBuilder.Entity<SystemUserPermissionActionCatalog>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("System#User#Permission#Action#Catalog");

                entity.HasComment("Права доступа пользователей к действиям в разрезе каталогов");

                entity.HasIndex(e => new { e.UserId, e.CatalogId }, "IX_System#User#Permission#Action#Catalog#UserID");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ActionId)
                    .HasColumnName("ActionID")
                    .HasComment("Идентификатор действия");

                entity.Property(e => e.CatalogId)
                    .HasColumnName("CatalogID")
                    .HasComment("Идентификатор каталога");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("Идентификатор пользователя");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.SystemUserPermissionActionCatalogs)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Permission#Action#Catalog_Global#GlobalEntryAttr");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.SystemUserPermissionActionCatalogs)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Permission#Action#Catalog_Catalog#Catalog");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemUserPermissionActionCatalogs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Permission#Action#Catalog_System#User");
            });

            modelBuilder.Entity<SystemUserPermissionColumn>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ColumnId });

                entity.ToTable("System#User#Permission#Column");

                entity.HasComment("Права доступа пользователей к столбцам");

                entity.HasIndex(e => e.UserId, "IX_System#User#Permission#Column#UserID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("Идентификатор роли");

                entity.Property(e => e.ColumnId)
                    .HasColumnName("ColumnID")
                    .HasComment("Идентификатор столбца");

                entity.Property(e => e.Editable).HasComment("Признак редактируемого столбца");

                entity.HasOne(d => d.Column)
                    .WithMany(p => p.SystemUserPermissionColumns)
                    .HasForeignKey(d => d.ColumnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Permission#Column_Global#GlobalEntryAttr");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemUserPermissionColumns)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Permission#Column_System#User");
            });

            modelBuilder.Entity<SystemUserPermissionEntry>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.EntryId });

                entity.ToTable("System#User#Permission#Entry");

                entity.HasComment("Права доступа пользователей к разделам");

                entity.HasIndex(e => e.UserId, "IX_System#User#Permission#Entry#UserID");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("Идентификатор роли");

                entity.Property(e => e.EntryId)
                    .HasColumnName("EntryID")
                    .HasComment("Идентификатор раздела");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.SystemUserPermissionEntries)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Permission#Entry_Global#GlobalEntry");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemUserPermissionEntries)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_System#User#Permission#Entry_System#User");
            });

            modelBuilder.Entity<TargetIndicator03T01Value>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("TargetIndicator#03#T01#Value");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.F0).HasMaxLength(250);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.Y0).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y10).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y4).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y5).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y6).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y7).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y8).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y9).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TargetIndicatorProject>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("TargetIndicator#Project");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.IndicatorId).HasColumnName("IndicatorID");

                entity.Property(e => e.Koeff).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Indicator)
                    .WithMany(p => p.TargetIndicatorProjects)
                    .HasForeignKey(d => d.IndicatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TargetIndicator#Project_IndicatorID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TargetIndicatorProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TargetIndicator#Project_ProjectID");
            });

            modelBuilder.Entity<TargetIndicatorValue>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_Target#TargetIndicator");

                entity.ToTable("TargetIndicator#Value");

                entity.HasIndex(e => new { e.IndicatorId, e.VersionId }, "IDX_IndicatorID_VersionID");

                entity.HasIndex(e => e.VersionId, "IDX_ValueByYear");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.F0).HasMaxLength(500);

                entity.Property(e => e.F1).HasMaxLength(500);

                entity.Property(e => e.IndicatorId).HasColumnName("IndicatorID");

                entity.Property(e => e.IndicatorName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IndicatorNum).HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.Y0).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y10).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y4).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y5).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y6).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y7).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y8).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y9).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<TaskElement>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Task#Element");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(user_name())");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskElements)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task#Element_TaskID");
            });

            modelBuilder.Entity<TaskHistory>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Task#History");

                entity.HasIndex(e => e.TaskId, "IDX_TaskID_Cover");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Content).HasMaxLength(2000);

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.StateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(user_name())");
            });

            modelBuilder.Entity<TaskResultValue>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Task#ResultValue");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.OldProposedDateFrom).HasColumnType("date");

                entity.Property(e => e.OldProposedDateTo).HasColumnType("date");

                entity.Property(e => e.OldProposedDictionaryId).HasColumnName("OldProposedDictionaryID");

                entity.Property(e => e.OldProposedValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ProposedDateFrom).HasColumnType("date");

                entity.Property(e => e.ProposedDateTo).HasColumnType("date");

                entity.Property(e => e.ProposedDictionaryId).HasColumnName("ProposedDictionaryID");

                entity.Property(e => e.ProposedValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.TaskElementId).HasColumnName("TaskElementID");

                entity.Property(e => e.TaskStepId).HasColumnName("TaskStepID");

                entity.Property(e => e.Variant).HasDefaultValueSql("((1))");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkEventId).HasColumnName("WorkEventID");

                entity.HasOne(d => d.TaskElement)
                    .WithMany(p => p.TaskResultValues)
                    .HasForeignKey(d => d.TaskElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task#ResultValue_TaskElementID");

                entity.HasOne(d => d.TaskStep)
                    .WithMany(p => p.TaskResultValues)
                    .HasForeignKey(d => d.TaskStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task#ResultValue_TaskStepID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.TaskResultValues)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Task#ResultValue_VersionID");
            });

            modelBuilder.Entity<TaskStep>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Task#Step");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DelayReason).HasMaxLength(2000);

                entity.Property(e => e.ExecDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleToId).HasColumnName("RoleToID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserFromId).HasColumnName("UserFromID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.UserToId).HasColumnName("UserToID");

                entity.HasOne(d => d.RoleTo)
                    .WithMany(p => p.TaskSteps)
                    .HasForeignKey(d => d.RoleToId)
                    .HasConstraintName("FK_Task#Step_RoleToID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskSteps)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task#Step_TaskID");

                entity.HasOne(d => d.UserFrom)
                    .WithMany(p => p.TaskStepUserFroms)
                    .HasForeignKey(d => d.UserFromId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task#Step_UserFromID");

                entity.HasOne(d => d.UserTo)
                    .WithMany(p => p.TaskStepUserTos)
                    .HasForeignKey(d => d.UserToId)
                    .HasConstraintName("FK_Task#Step_UserToID");
            });

            modelBuilder.Entity<TaskStepElement>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Task#Step#Element");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.TaskElementId).HasColumnName("TaskElementID");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.TaskStepElements)
                    .HasForeignKey(d => d.StepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task#Step#Element_StepID");

                entity.HasOne(d => d.TaskElement)
                    .WithMany(p => p.TaskStepElements)
                    .HasForeignKey(d => d.TaskElementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task#Step#Element_ElementID");
            });

            modelBuilder.Entity<TaskTask>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Task#Task");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DelayReason).HasMaxLength(2000);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ExecDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.TaskTypeId).HasColumnName("TaskTypeID");

                entity.Property(e => e.UserName).HasMaxLength(260);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TaskTaskCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Task#Task_CustomerID");

                entity.HasOne(d => d.SeniorWorksNavigation)
                    .WithMany(p => p.TaskTaskSeniorWorksNavigations)
                    .HasForeignKey(d => d.SeniorWorks)
                    .HasConstraintName("FK_Task#Task_Agent#Agent");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.TaskTasks)
                    .HasForeignKey(d => d.StageId)
                    .HasConstraintName("FK_Task#Task_StageID");

                entity.HasOne(d => d.TaskType)
                    .WithMany(p => p.TaskTasks)
                    .HasForeignKey(d => d.TaskTypeId)
                    .HasConstraintName("FK_Task#Task_TaskTypeID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.TaskTasks)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Task#Task_VersionID");
            });

            modelBuilder.Entity<TechnicCompatibility>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Technic#Compatibility");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CountKa).HasColumnName("CountKA");

                entity.Property(e => e.SpaceportId).HasColumnName("SpaceportID");

                entity.Property(e => e.TypeKaid).HasColumnName("TypeKAID");

                entity.Property(e => e.TypeObid).HasColumnName("TypeOBID");

                entity.Property(e => e.TypeRbid).HasColumnName("TypeRBID");

                entity.Property(e => e.TypeRnid).HasColumnName("TypeRNID");

                entity.HasOne(d => d.TypeKa)
                    .WithMany(p => p.TechnicCompatibilityTypeKas)
                    .HasForeignKey(d => d.TypeKaid)
                    .HasConstraintName("FK_Technic#Compatibility_Technic#Type");

                entity.HasOne(d => d.TypeOb)
                    .WithMany(p => p.TechnicCompatibilityTypeObs)
                    .HasForeignKey(d => d.TypeObid)
                    .HasConstraintName("FK_Technic#Compatibility_TypeOBID");

                entity.HasOne(d => d.TypeRb)
                    .WithMany(p => p.TechnicCompatibilityTypeRbs)
                    .HasForeignKey(d => d.TypeRbid)
                    .HasConstraintName("FK_Technic#Compatibility_Technic#Type1");

                entity.HasOne(d => d.TypeRn)
                    .WithMany(p => p.TechnicCompatibilityTypeRns)
                    .HasForeignKey(d => d.TypeRnid)
                    .HasConstraintName("FK_Technic#Compatibility_Technic#Type2");
            });

            modelBuilder.Entity<TechnicParam>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Technic#Param");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_RID");

                entity.HasIndex(e => e.ParentId, "IX_Technic#Param_ParentID");

                entity.HasIndex(e => new { e.ParentId, e.VersionId, e.ParamId, e.Rid }, "_dta_index_Technic#Param_5_1016442745__K5_K7_K6_K1");

                entity.HasIndex(e => new { e.ParamId, e.VersionId, e.ParentId, e.Rid }, "_dta_index_Technic#Param_5_1016442745__K6_K7_K5_K1");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Param)
                    .WithMany(p => p.TechnicParams)
                    .HasForeignKey(d => d.ParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Technic#P__Param__2F06AA31");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.TechnicParams)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Technic#Param_Technic#Param_Version#Version");
            });

            modelBuilder.Entity<TechnicStatus>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Technic#Status");

                entity.HasIndex(e => new { e.ParentId, e.VersionId, e.State }, "_dta_index_Technic#Status_5_667969556__K2_K3_K4_6");

                entity.HasIndex(e => new { e.ParentId, e.VersionId, e.State, e.EntryId, e.Rid }, "_dta_index_Technic#Status_5_667969556__K2_K3_K4_K6_K1");

                entity.HasIndex(e => new { e.ParentId, e.VersionId, e.EntryId, e.State, e.Rid }, "_dta_index_Technic#Status_5_667969556__K2_K3_K6_K4_K1");

                entity.HasIndex(e => new { e.State, e.ParentId, e.VersionId, e.EntryId, e.Rid }, "_dta_index_Technic#Status_5_667969556__K4_K2_K3_K6_K1");

                entity.HasIndex(e => new { e.State, e.VersionId, e.ParentId, e.EntryId, e.Rid }, "_dta_index_Technic#Status_5_667969556__K4_K3_K2_K6_K1");

                entity.HasIndex(e => new { e.EntryId, e.State, e.ParentId, e.VersionId, e.Rid }, "_dta_index_Technic#Status_5_667969556__K6_K4_K2_K3_K1");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.DocumentNote).HasMaxLength(250);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.StateDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.TechnicStatuses)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Technic#Status_EntryID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.TechnicStatuses)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Technic#Status_ParentID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.TechnicStatuses)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Technic#Status_Version");
            });

            modelBuilder.Entity<TechnicType>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Technic#Type");

                entity.HasIndex(e => e.Rid, "_dta_index_Technic#Type_5_703445680__K1_4683");

                entity.HasIndex(e => new { e.Rid, e.EntryId, e.Kkid, e.ClassRn }, "_dta_index_Technic#Type_5_703445680__K1_K2_K7_K5_3_4");

                entity.HasIndex(e => new { e.Rid, e.Kkid }, "_dta_index_Technic#Type_5_703445680__K1_K7");

                entity.HasIndex(e => new { e.EntryId, e.ClassRn }, "_dta_index_Technic#Type_5_703445680__K2_K5");

                entity.HasIndex(e => new { e.EntryId, e.ClassRn, e.Rid, e.Kkid }, "_dta_index_Technic#Type_5_703445680__K2_K5_K1_K7_3_4_8");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ClassRn)
                    .HasColumnName("ClassRN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PlanSas)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PlanSAS");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.TechnicTypes)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Technic#Type_Global#GlobalEntry");

                entity.HasOne(d => d.Kk)
                    .WithMany(p => p.TechnicTypes)
                    .HasForeignKey(d => d.Kkid)
                    .HasConstraintName("FK_Technic#Type_SpaceSystem#SpaceSystem");
            });

            modelBuilder.Entity<TechnicTypeAnalog>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Technic#Type#Analog");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.AnalogId).HasColumnName("AnalogID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Analog)
                    .WithMany(p => p.TechnicTypeAnalogAnalogs)
                    .HasForeignKey(d => d.AnalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Technic#Type#Analog_Analog");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.TechnicTypeAnalogParents)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Technic#Type#Analog_Parent");
            });

            modelBuilder.Entity<TechnicTypeParam>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Technic#Type#Param");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_RID");

                entity.HasIndex(e => new { e.ParentId, e.VersionId, e.ParamId, e.Rid }, "_dta_index_Technic#Type#Param_5_1970926193__K5_K7_K6_K1");

                entity.HasIndex(e => new { e.ParamId, e.VersionId, e.ParentId, e.Rid }, "_dta_index_Technic#Type#Param_5_1970926193__K6_K7_K5_K1");

                entity.HasIndex(e => new { e.VersionId, e.ParamId }, "_dta_index_Technic#Type#Param_5_1970926193__K7_K6_1_5");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Param)
                    .WithMany(p => p.TechnicTypeParams)
                    .HasForeignKey(d => d.ParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Technic#Type#Param__ParamID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.TechnicTypeParams)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Technic#Type#Param_ParentID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.TechnicTypeParams)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Technic#Param_Technic#Type#Param_Version#Version");
            });

            modelBuilder.Entity<TmpParamValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp#Param#Value");

                entity.HasIndex(e => e.UserName, "IX_Tmp#Param#Value_missing_26");

                entity.HasIndex(e => new { e.UserName, e.UnitName, e.LinkNum3 }, "IX_Tmp#Param#Value_missing_35");

                entity.HasIndex(e => new { e.UserName, e.UnitName }, "IX_Tmp#Param#Value_missing_58");

                entity.Property(e => e.DictionaryValueId1).HasColumnName("DictionaryValueID1");

                entity.Property(e => e.DictionaryValueId10).HasColumnName("DictionaryValueID10");

                entity.Property(e => e.DictionaryValueId11).HasColumnName("DictionaryValueID11");

                entity.Property(e => e.DictionaryValueId12).HasColumnName("DictionaryValueID12");

                entity.Property(e => e.DictionaryValueId13).HasColumnName("DictionaryValueID13");

                entity.Property(e => e.DictionaryValueId14).HasColumnName("DictionaryValueID14");

                entity.Property(e => e.DictionaryValueId15).HasColumnName("DictionaryValueID15");

                entity.Property(e => e.DictionaryValueId16).HasColumnName("DictionaryValueID16");

                entity.Property(e => e.DictionaryValueId17).HasColumnName("DictionaryValueID17");

                entity.Property(e => e.DictionaryValueId18).HasColumnName("DictionaryValueID18");

                entity.Property(e => e.DictionaryValueId19).HasColumnName("DictionaryValueID19");

                entity.Property(e => e.DictionaryValueId2).HasColumnName("DictionaryValueID2");

                entity.Property(e => e.DictionaryValueId20).HasColumnName("DictionaryValueID20");

                entity.Property(e => e.DictionaryValueId3).HasColumnName("DictionaryValueID3");

                entity.Property(e => e.DictionaryValueId4).HasColumnName("DictionaryValueID4");

                entity.Property(e => e.DictionaryValueId5).HasColumnName("DictionaryValueID5");

                entity.Property(e => e.DictionaryValueId6).HasColumnName("DictionaryValueID6");

                entity.Property(e => e.DictionaryValueId7).HasColumnName("DictionaryValueID7");

                entity.Property(e => e.DictionaryValueId8).HasColumnName("DictionaryValueID8");

                entity.Property(e => e.DictionaryValueId9).HasColumnName("DictionaryValueID9");

                entity.Property(e => e.LinkType1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType10).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType11).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType12).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType13).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType14).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType15).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType16).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType17).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType18).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType19).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType2).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType20).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType3).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType4).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType5).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType6).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType7).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType8).HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkType9).HasDefaultValueSql("((0))");

                entity.Property(e => e.NPar1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar1");

                entity.Property(e => e.NPar10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar10");

                entity.Property(e => e.NPar11)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar11");

                entity.Property(e => e.NPar12)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar12");

                entity.Property(e => e.NPar13)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar13");

                entity.Property(e => e.NPar14)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar14");

                entity.Property(e => e.NPar15)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar15");

                entity.Property(e => e.NPar16)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar16");

                entity.Property(e => e.NPar17)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar17");

                entity.Property(e => e.NPar18)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar18");

                entity.Property(e => e.NPar19)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar19");

                entity.Property(e => e.NPar2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar2");

                entity.Property(e => e.NPar20)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar20");

                entity.Property(e => e.NPar21)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar21");

                entity.Property(e => e.NPar22)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar22");

                entity.Property(e => e.NPar23)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar23");

                entity.Property(e => e.NPar24)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar24");

                entity.Property(e => e.NPar25)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar25");

                entity.Property(e => e.NPar26)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar26");

                entity.Property(e => e.NPar27)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar27");

                entity.Property(e => e.NPar28)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar28");

                entity.Property(e => e.NPar29)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar29");

                entity.Property(e => e.NPar3)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar3");

                entity.Property(e => e.NPar30)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar30");

                entity.Property(e => e.NPar4)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar4");

                entity.Property(e => e.NPar5)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar5");

                entity.Property(e => e.NPar6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar6");

                entity.Property(e => e.NPar7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar7");

                entity.Property(e => e.NPar8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar8");

                entity.Property(e => e.NPar9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar9");

                entity.Property(e => e.ParamId1).HasColumnName("ParamID1");

                entity.Property(e => e.ParamId10).HasColumnName("ParamID10");

                entity.Property(e => e.ParamId11).HasColumnName("ParamID11");

                entity.Property(e => e.ParamId12).HasColumnName("ParamID12");

                entity.Property(e => e.ParamId13).HasColumnName("ParamID13");

                entity.Property(e => e.ParamId14).HasColumnName("ParamID14");

                entity.Property(e => e.ParamId15).HasColumnName("ParamID15");

                entity.Property(e => e.ParamId16).HasColumnName("ParamID16");

                entity.Property(e => e.ParamId17).HasColumnName("ParamID17");

                entity.Property(e => e.ParamId18).HasColumnName("ParamID18");

                entity.Property(e => e.ParamId19).HasColumnName("ParamID19");

                entity.Property(e => e.ParamId2).HasColumnName("ParamID2");

                entity.Property(e => e.ParamId20).HasColumnName("ParamID20");

                entity.Property(e => e.ParamId3).HasColumnName("ParamID3");

                entity.Property(e => e.ParamId4).HasColumnName("ParamID4");

                entity.Property(e => e.ParamId5).HasColumnName("ParamID5");

                entity.Property(e => e.ParamId6).HasColumnName("ParamID6");

                entity.Property(e => e.ParamId7).HasColumnName("ParamID7");

                entity.Property(e => e.ParamId8).HasColumnName("ParamID8");

                entity.Property(e => e.ParamId9).HasColumnName("ParamID9");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.SPar1).HasColumnName("sPar1");

                entity.Property(e => e.SPar10).HasColumnName("sPar10");

                entity.Property(e => e.SPar11).HasColumnName("sPar11");

                entity.Property(e => e.SPar12).HasColumnName("sPar12");

                entity.Property(e => e.SPar13).HasColumnName("sPar13");

                entity.Property(e => e.SPar14).HasColumnName("sPar14");

                entity.Property(e => e.SPar15).HasColumnName("sPar15");

                entity.Property(e => e.SPar16).HasColumnName("sPar16");

                entity.Property(e => e.SPar17).HasColumnName("sPar17");

                entity.Property(e => e.SPar18).HasColumnName("sPar18");

                entity.Property(e => e.SPar19).HasColumnName("sPar19");

                entity.Property(e => e.SPar2).HasColumnName("sPar2");

                entity.Property(e => e.SPar20).HasColumnName("sPar20");

                entity.Property(e => e.SPar3).HasColumnName("sPar3");

                entity.Property(e => e.SPar4).HasColumnName("sPar4");

                entity.Property(e => e.SPar5).HasColumnName("sPar5");

                entity.Property(e => e.SPar6).HasColumnName("sPar6");

                entity.Property(e => e.SPar7).HasColumnName("sPar7");

                entity.Property(e => e.SPar8).HasColumnName("sPar8");

                entity.Property(e => e.SPar9).HasColumnName("sPar9");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.ValueId1).HasColumnName("ValueID1");

                entity.Property(e => e.ValueId10).HasColumnName("ValueID10");

                entity.Property(e => e.ValueId11).HasColumnName("ValueID11");

                entity.Property(e => e.ValueId12).HasColumnName("ValueID12");

                entity.Property(e => e.ValueId13).HasColumnName("ValueID13");

                entity.Property(e => e.ValueId14).HasColumnName("ValueID14");

                entity.Property(e => e.ValueId15).HasColumnName("ValueID15");

                entity.Property(e => e.ValueId16).HasColumnName("ValueID16");

                entity.Property(e => e.ValueId17).HasColumnName("ValueID17");

                entity.Property(e => e.ValueId18).HasColumnName("ValueID18");

                entity.Property(e => e.ValueId19).HasColumnName("ValueID19");

                entity.Property(e => e.ValueId2).HasColumnName("ValueID2");

                entity.Property(e => e.ValueId20).HasColumnName("ValueID20");

                entity.Property(e => e.ValueId3).HasColumnName("ValueID3");

                entity.Property(e => e.ValueId4).HasColumnName("ValueID4");

                entity.Property(e => e.ValueId5).HasColumnName("ValueID5");

                entity.Property(e => e.ValueId6).HasColumnName("ValueID6");

                entity.Property(e => e.ValueId7).HasColumnName("ValueID7");

                entity.Property(e => e.ValueId8).HasColumnName("ValueID8");

                entity.Property(e => e.ValueId9).HasColumnName("ValueID9");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");
            });

            modelBuilder.Entity<TmpParamValueR>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp#Param#ValueR");

                entity.Property(e => e.DictionaryValueId1).HasColumnName("DictionaryValueID1");

                entity.Property(e => e.LinkType1).HasDefaultValueSql("((0))");

                entity.Property(e => e.NPar1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar1");

                entity.Property(e => e.ParamId1).HasColumnName("ParamID1");

                entity.Property(e => e.ParamId12).HasColumnName("ParamID12");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.SPar1).HasColumnName("sPar1");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.ValueId1).HasColumnName("ValueID1");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");
            });

            modelBuilder.Entity<TmpRiscFactorCombination>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Tmp#RiscFactor#Combination");

                entity.HasIndex(e => new { e.Numb, e.Fcount }, "_dta_index_Tmp#RiscFactor#Combination_10_1134119281__K2_K5_3");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Acombination)
                    .HasMaxLength(2000)
                    .HasColumnName("ACombination");

                entity.Property(e => e.Fcount).HasColumnName("FCount");

                entity.Property(e => e.Pcombination)
                    .HasMaxLength(2000)
                    .HasColumnName("PCombination");
            });

            modelBuilder.Entity<TmpStrCopy>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("TmpStrCopy");

                entity.HasIndex(e => e.Ridnew, "IX_TmpStrCopy");

                entity.HasIndex(e => e.Ridold, "IX_TmpStrCopy_1");

                entity.HasIndex(e => e.ProcessId, "IX_TmpStrCopy_2");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Ridnew).HasColumnName("RIDNEW");

                entity.Property(e => e.Ridold).HasColumnName("RIDOLD");
            });

            modelBuilder.Entity<UserApplicationApplication>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__UserAppl__CAFF4132F10F5C76");

                entity.ToTable("UserApplication#Application");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Application).HasMaxLength(1);

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(260);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Version).HasMaxLength(50);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.UserApplicationApplications)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserApplication#Application_Catalog#Catalog");
            });

            modelBuilder.Entity<UserArpParam>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("UserARP#Params");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.DataMask).HasMaxLength(250);

                entity.Property(e => e.DefaultValueDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultValueNum).HasColumnType("numeric(17, 4)");

                entity.Property(e => e.DefaultValueStr).HasMaxLength(250);

                entity.Property(e => e.IsCanGetList).HasColumnName("isCanGetList");

                entity.Property(e => e.IsOutput).HasColumnName("isOUTPUT");

                entity.Property(e => e.IsRid).HasColumnName("isRID");

                entity.Property(e => e.Label).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcedureParam).HasMaxLength(250);
            });

            modelBuilder.Entity<UserArpSection>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("UserARP#Section");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<UserGraphGraph>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("UserGraph#Graph");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.Graph).HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ProcedureName).HasMaxLength(250);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.UserGraphGraphs)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGraph#Graph_Catalog");
            });

            modelBuilder.Entity<UserProcedureProcedure>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__UserProc__CAFF413232EFEC38");

                entity.ToTable("UserProcedure#Procedure");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PType).HasColumnName("pType");

                entity.Property(e => e.ProcedureName).HasMaxLength(260);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.UserProcedureProcedures)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProcedure#Procedure_Catalog#Catalog");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User#Profile");

                entity.Property(e => e.FileData).HasColumnType("image");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileVersion).HasMaxLength(50);

                entity.Property(e => e.LastOperation).HasColumnType("datetime");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<UserReportReport>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("UserReport#Report");

                entity.HasIndex(e => e.CatalogId, "IX_UserReport#Report_CatalogID");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.PType)
                    .HasColumnName("pType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Report).HasColumnType("image");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.UserReportReports)
                    .HasForeignKey(d => d.CatalogId)
                    .HasConstraintName("FK_UserReport#Report_Catalog#Catalog");
            });

            modelBuilder.Entity<UserReportRole>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_UserReport#Role_RID");

                entity.ToTable("UserReport#Role");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserReportRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserReport#Role_RoleID");
            });

            modelBuilder.Entity<UserReportSection>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__UserRepo__CAFF41320BAA9AAE");

                entity.ToTable("UserReport#Section");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.UserReportSections)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK__UserRepor__Secti__3B6C8116");
            });

            modelBuilder.Entity<UserUser>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__User#Use__CAFF413217409D23");

                entity.ToTable("User#User");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.UserName).HasMaxLength(260);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.UserUsers)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User#User__Catal__2FFACE6A");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.UserUsers)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User#User__Perso__30EEF2A3");
            });

            modelBuilder.Entity<UserVersion>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("User#Version");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserVersions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_User#Version_System#User");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.UserVersions)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_User#Version_Version#Version");
            });

            modelBuilder.Entity<VAgentAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAgent#Agent");

                entity.Property(e => e.AddName).HasMaxLength(2000);

                entity.Property(e => e.Address).HasMaxLength(2000);

                entity.Property(e => e.AgentCategoryCode)
                    .HasMaxLength(50)
                    .HasColumnName("AgentCategory_Code");

                entity.Property(e => e.AgentTypeCode)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("AgentType_Code");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Cpp)
                    .HasMaxLength(50)
                    .HasColumnName("CPP");

                entity.Property(e => e.DateR).HasColumnType("smalldatetime");

                entity.Property(e => e.FirstName).HasMaxLength(260);

                entity.Property(e => e.Inn)
                    .HasMaxLength(50)
                    .HasColumnName("INN");

                entity.Property(e => e.LastName).HasMaxLength(260);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Ogrn)
                    .HasMaxLength(50)
                    .HasColumnName("OGRN");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(50)
                    .HasColumnName("OKPO");

                entity.Property(e => e.Patronymic).HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UserName).HasMaxLength(260);
            });

            modelBuilder.Entity<VAgentContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAgent#Contact");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.ContactTypeId).HasColumnName("ContactTypeID");

                entity.Property(e => e.ContactTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("ContactTypeID_Code");

                entity.Property(e => e.ContactTypeIdName)
                    .HasMaxLength(260)
                    .HasColumnName("ContactTypeID_Name");

                entity.Property(e => e.ContactValue).HasMaxLength(2000);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VAgentGroupAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAgentGroup#Agent");

                entity.Property(e => e.AddName).HasMaxLength(2000);

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.AgentIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AgentID_Code");

                entity.Property(e => e.AgentIdName)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AgentID_Name");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VAgentGroupGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAgentGroup#Group");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VAgentPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAgent#Person");

                entity.Property(e => e.AcademicDegree).HasMaxLength(250);

                entity.Property(e => e.AcademicTitle).HasMaxLength(250);

                entity.Property(e => e.AddEducation).HasMaxLength(2000);

                entity.Property(e => e.AgentCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("Agent_Code");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.AgentIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AgentID_Code");

                entity.Property(e => e.AgentIdDateR)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AgentID_DateR");

                entity.Property(e => e.AgentIdFirstName)
                    .HasMaxLength(260)
                    .HasColumnName("AgentID_FirstName");

                entity.Property(e => e.AgentIdFullName)
                    .HasMaxLength(782)
                    .HasColumnName("AgentID_FullName");

                entity.Property(e => e.AgentIdLastName)
                    .HasMaxLength(260)
                    .HasColumnName("AgentID_LastName");

                entity.Property(e => e.AgentIdPatronymic)
                    .HasMaxLength(260)
                    .HasColumnName("AgentID_Patronymic");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.CategoryIdName)
                    .HasMaxLength(260)
                    .HasColumnName("CategoryID_Name");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Department_Code");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("DepartmentID_Code");

                entity.Property(e => e.Education).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .HasColumnName("Post_Code");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.PostIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("PostID_Code");

                entity.Property(e => e.ProffKoef).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TabNum).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(260);

                entity.Property(e => e.WorkExp).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<VCatalogCatalog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCatalog#Catalog");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<VDashBoardDashBoard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDashBoard#DashBoard");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.Graph).HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VDashboardFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDashboardFilter");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<VDepartmentDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDepartment#Department");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.CategoryIdName)
                    .HasMaxLength(260)
                    .IsUnicode(false)
                    .HasColumnName("CategoryID_Name");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Num)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(260)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VDictionaryDictionary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Dictionary");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.EntrySystemName)
                    .HasMaxLength(160)
                    .IsUnicode(false)
                    .HasColumnName("Entry_SystemName");

                entity.Property(e => e.IsSystem).HasColumnName("isSystem");

                entity.Property(e => e.Name)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VDictionaryEventType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#EventType");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Level0)
                    .HasMaxLength(50)
                    .HasColumnName("level0");

                entity.Property(e => e.Level1)
                    .HasMaxLength(50)
                    .HasColumnName("level1");

                entity.Property(e => e.NLevel0).HasColumnName("nLevel0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VDictionaryLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Link");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryLinkElement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Link#Element");

                entity.Property(e => e.EntryIdin).HasColumnName("EntryIDIn");

                entity.Property(e => e.EntryIdout).HasColumnName("EntryIDOut");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryMeasure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Measure");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.NativCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UniCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VDictionaryPriorityCriterion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#PriorityCriterion");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.CategoryIdName)
                    .HasMaxLength(260)
                    .HasColumnName("CategoryID_Name");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsCalculated).HasColumnName("isCalculated");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.RankValue).HasColumnType("numeric(37, 16)");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VDictionaryPriorityCriterionKind>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#PriorityCriterion#Kind");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.RankValue).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VDictionaryPriorityCriterionKindSpec>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#PriorityCriterion#Kind#Spec");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsCalculated).HasColumnName("isCalculated");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RankValue).HasColumnType("numeric(37, 16)");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VDictionaryPriorityCriterionList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#PriorityCriterion#List");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(50)
                    .HasColumnName("Category_Code");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsCalculated).HasColumnName("isCalculated");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VDictionaryProjectWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Project#Work");

                entity.Property(e => e.BaseRank).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.KindIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("KindID_Code");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VDictionaryRisk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Risk");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActual).HasColumnName("isActual");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(260)
                    .HasColumnName("TypeID_Name");
            });

            modelBuilder.Entity<VDictionaryRiskObject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Risk#Object");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PrintName).HasMaxLength(1000);

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("Version_Name");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VDictionaryStageType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#StageType");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Gostid).HasColumnName("GOSTID");

                entity.Property(e => e.GostidCode)
                    .HasMaxLength(50)
                    .HasColumnName("GOSTID_Code");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TechnologyReadyLevelId).HasColumnName("TechnologyReadyLevelID");

                entity.Property(e => e.TechnologyReadyLevelIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TechnologyReadyLevelID_Code");

                entity.Property(e => e.TechnologyReadyLevelIdName)
                    .HasMaxLength(500)
                    .HasColumnName("TechnologyReadyLevelID_Name");

                entity.Property(e => e.WorkKindId).HasColumnName("WorkKindID");

                entity.Property(e => e.WorkKindIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkKindID_Code");

                entity.Property(e => e.WorkKindIdName)
                    .HasMaxLength(260)
                    .HasColumnName("WorkKindID_Name");
            });

            modelBuilder.Entity<VDictionaryTargetIndicator>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#TargetIndicator");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ElementTypeCode)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Code");

                entity.Property(e => e.IsCalcEfficiency).HasColumnName("isCalcEfficiency");

                entity.Property(e => e.IsPrint).HasColumnName("isPrint");

                entity.Property(e => e.IsUpdate).HasColumnName("isUpdate");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.MeasureIdShortCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_ShortCode");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ProcedureName).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SFormat)
                    .HasMaxLength(100)
                    .HasColumnName("sFormat");

                entity.Property(e => e.ShortName).HasMaxLength(250);

                entity.Property(e => e.TrendTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TrendType_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTargetIndicatorEtalon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#TargetIndicator#Etalon");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.F0).HasMaxLength(500);

                entity.Property(e => e.F1).HasMaxLength(500);

                entity.Property(e => e.IndicatorId).HasColumnName("IndicatorID");

                entity.Property(e => e.IndicatorName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IndicatorNum).HasMaxLength(50);

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.MeasureIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.SFormat)
                    .HasMaxLength(100)
                    .HasColumnName("sFormat");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTargetIndicatorMethod>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#TargetIndicator#Method");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Method).HasColumnType("image");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTargetIndicatorPriority>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#TargetIndicator#Priority");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IndicatorPriority)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Indicator_Priority");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(50)
                    .HasColumnName("Project_Code");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectKoeff)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("Project_Koeff");

                entity.Property(e => e.ProjectNum)
                    .HasMaxLength(50)
                    .HasColumnName("Project_Num");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkDirectionCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkDirection_Code");

                entity.Property(e => e.WorkDirectionId).HasColumnName("WorkDirectionID");

                entity.Property(e => e.WorkDirectionName).HasMaxLength(2000);

                entity.Property(e => e.WorkDirectionNumb)
                    .HasMaxLength(50)
                    .HasColumnName("WorkDirection_Numb");

                entity.Property(e => e.WorkDirectionPriority)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("WorkDirection_Priority");
            });

            modelBuilder.Entity<VDictionaryTechnic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SystemName).HasMaxLength(160);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(260)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnicKa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic#KA");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.CategoryIdName)
                    .HasMaxLength(260)
                    .HasColumnName("CategoryID_Name");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DocumentNote).HasMaxLength(250);

                entity.Property(e => e.ExtName).HasMaxLength(311);

                entity.Property(e => e.IsBudget).HasColumnName("isBudget");

                entity.Property(e => e.KaRidCode).HasColumnName("kaRID_Code");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.KkidDocNum).HasColumnName("KKID_DocNum");

                entity.Property(e => e.KkidName)
                    .HasMaxLength(1000)
                    .HasColumnName("KKID_Name");

                entity.Property(e => e.NCountEvent).HasColumnName("nCountEvent");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.PlanSas)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PlanSAS");

                entity.Property(e => e.PlanWorkTime).HasColumnType("numeric(21, 6)");

                entity.Property(e => e.RbRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("rbRID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RnRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("rnRID_Code");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSetName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceSet_Name");

                entity.Property(e => e.SpaceSystemCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystem_Code");

                entity.Property(e => e.SpaceSystemId).HasColumnName("SpaceSystemID");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnicKaAnalog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic#KA#Analog");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.CategoryIdName)
                    .HasMaxLength(260)
                    .HasColumnName("CategoryID_Name");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DocumentNote).HasMaxLength(250);

                entity.Property(e => e.ExtName).HasMaxLength(311);

                entity.Property(e => e.KaRidCode).HasColumnName("kaRID_Code");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.KkidDocNum).HasColumnName("KKID_DocNum");

                entity.Property(e => e.KkidName)
                    .HasMaxLength(1000)
                    .HasColumnName("KKID_Name");

                entity.Property(e => e.NCountEvent).HasColumnName("nCountEvent");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RbRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("rbRID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RnRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("rnRID_Code");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSetName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceSet_Name");

                entity.Property(e => e.SpaceSystemCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystem_Code");

                entity.Property(e => e.SpaceSystemId).HasColumnName("SpaceSystemID");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnicKaLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic#KA#Light");

                entity.Property(e => e.ExtName).HasMaxLength(311);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnicOb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic#OB");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateManufacture).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.GuaranteedStorageNom)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("GuaranteedStorage_Nom");

                entity.Property(e => e.GuaranteedStorageRkt)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("GuaranteedStorage_RKT");

                entity.Property(e => e.NCountEvent).HasColumnName("nCountEvent");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSetName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceSet_Name");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.StorageExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnicOb1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic#OB_1");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Name)
                    .HasMaxLength(260)
                    .HasColumnName("NAME");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSetName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceSet_Name");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnicOther>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic#OTHER");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.NCountEvent).HasColumnName("nCountEvent");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSetName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceSet_Name");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode).HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName).HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnicRb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic#RB");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateManufacture).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.GuaranteedStorageNom)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("GuaranteedStorage_Nom");

                entity.Property(e => e.GuaranteedStorageRkt)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("GuaranteedStorage_RKT");

                entity.Property(e => e.KaRidCode).HasColumnName("kaRID_Code");

                entity.Property(e => e.NCountEvent).HasColumnName("nCountEvent");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RnRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("rnRID_Code");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSetName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceSet_Name");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.StorageExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnicRb1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic#RB_1");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RnRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("rnRID_Code");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSetName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceSet_Name");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnicRn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic#RN");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.ClassRn).HasColumnName("ClassRN");

                entity.Property(e => e.ClassRnCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClassRN_Code");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateManufacture).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.GuaranteedStorageNom)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("GuaranteedStorage_Nom");

                entity.Property(e => e.GuaranteedStorageRkt)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("GuaranteedStorage_RKT");

                entity.Property(e => e.KaRidCode).HasColumnName("kaRID_Code");

                entity.Property(e => e.NCountEvent).HasColumnName("nCountEvent");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.RbRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("rbRID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSetName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceSet_Name");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.StorageExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnicRn1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technic#RN_1");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.ClassRn).HasColumnName("ClassRN");

                entity.Property(e => e.ClassRnCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClassRN_Code");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.RbRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("rbRID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSetName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceSet_Name");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryTechnologyReadyLevel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Technology#Ready#Level");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RealizeForm).HasMaxLength(500);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VDictionaryWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work");

                entity.Property(e => e.BaseRank).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryWorkId).HasColumnName("DictionaryWorkID");

                entity.Property(e => e.FinDirectionCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("FinDirection_Code");

                entity.Property(e => e.Gostid).HasColumnName("GOSTID");

                entity.Property(e => e.GostidCode)
                    .HasMaxLength(50)
                    .HasColumnName("GOSTID_Code");

                entity.Property(e => e.InfoCode)
                    .HasMaxLength(56)
                    .IsUnicode(false)
                    .HasColumnName("Info_Code");

                entity.Property(e => e.IsDoneValue)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("isDoneValue");

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.KindIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("KindID_Code");

                entity.Property(e => e.LastDateRiskCalculate).HasColumnType("smalldatetime");

                entity.Property(e => e.Level1)
                    .HasMaxLength(311)
                    .HasColumnName("level1");

                entity.Property(e => e.Level2)
                    .HasMaxLength(50)
                    .HasColumnName("level2");

                entity.Property(e => e.Level3).HasMaxLength(50);

                entity.Property(e => e.Level4).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PrintName).HasMaxLength(1000);

                entity.Property(e => e.Priority).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProgNumSort).HasMaxLength(200);

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.R12).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R13).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R21).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R23).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R31).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R32).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RiskValueR)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R");

                entity.Property(e => e.RiskValueR1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R1");

                entity.Property(e => e.RiskValueR2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R2");

                entity.Property(e => e.RiskValueR3)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R3");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(50)
                    .HasColumnName("Section_Code");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionIdCode)
                    .HasMaxLength(464)
                    .HasColumnName("SectionID_Code");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.StageCode)
                    .HasMaxLength(50)
                    .HasColumnName("Stage_Code");

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.StageIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("StageID_Code");

                entity.Property(e => e.StagePercent).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.StageTypeId).HasColumnName("StageTypeID");

                entity.Property(e => e.StageTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("StageTypeID_Code");

                entity.Property(e => e.StageTypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("StageTypeID_Name");

                entity.Property(e => e.StageValue).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.WorkCategoryId).HasColumnName("WorkCategoryID");

                entity.Property(e => e.WorkCategoryIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkCategoryID_Code");

                entity.Property(e => e.WorkCodeCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkCode_Code");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VDictionaryWorkCompareVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#CompareVersion");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.FinDirectionCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("FinDirection_Code");

                entity.Property(e => e.InfoCode)
                    .HasMaxLength(56)
                    .IsUnicode(false)
                    .HasColumnName("Info_Code");

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.KindIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("KindID_Code");

                entity.Property(e => e.Level1)
                    .HasMaxLength(311)
                    .HasColumnName("level1");

                entity.Property(e => e.Level2)
                    .HasMaxLength(50)
                    .HasColumnName("level2");

                entity.Property(e => e.Level3).HasMaxLength(50);

                entity.Property(e => e.Level4).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PrintName).HasMaxLength(1000);

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(50)
                    .HasColumnName("Section_Code");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionIdCode).HasColumnName("SectionID_Code");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.StageCode)
                    .HasMaxLength(50)
                    .HasColumnName("Stage_Code");

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.StageIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("StageID_Code");

                entity.Property(e => e.StagePercent).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.StageValue).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Version1Code).HasColumnName("Version1_Code");

                entity.Property(e => e.Version2Code).HasColumnName("Version2_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkCode_Code");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VDictionaryWorkDurationOkr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Duration#OKR");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");
            });

            modelBuilder.Entity<VDictionaryWorkEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Event");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.DictionaryValueIdCode)
                    .HasMaxLength(255)
                    .HasColumnName("DictionaryValueID_Code");

                entity.Property(e => e.EventPercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.EventTypeIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.EventTypeIdShortCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("EventTypeID_ShortCode");

                entity.Property(e => e.GroupName).HasMaxLength(2000);

                entity.Property(e => e.IsDone).HasColumnName("isDone");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.Name1).HasMaxLength(4000);

                entity.Property(e => e.ParentEventId).HasColumnName("ParentEventID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SpaceCraftIdCode)
                    .HasMaxLength(269)
                    .HasColumnName("SpaceCraftID_Code");

                entity.Property(e => e.SpacecraftId).HasColumnName("SpacecraftID");

                entity.Property(e => e.StageSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VDictionaryWorkEventDistSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Event#DistSum");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.EventDateTo).HasColumnType("date");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventName).HasMaxLength(2000);

                entity.Property(e => e.FinId).HasColumnName("FinID");

                entity.Property(e => e.FinName).HasMaxLength(2000);

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.NSum)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryWorkEventFin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Event#Fin");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.DictionaryValueIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("DictionaryValueID_Code");

                entity.Property(e => e.EventPercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.EventTypeIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.GroupName).HasMaxLength(2000);

                entity.Property(e => e.IsDone).HasColumnName("isDone");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.Name1).HasMaxLength(4000);

                entity.Property(e => e.ParentEventId).HasColumnName("ParentEventID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StageSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VDictionaryWorkEventFinPivot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Event#FinPivot");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EventPercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EventRid).HasColumnName("EventRID");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.StagePercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.StageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkRid).HasColumnName("WorkRID");
            });

            modelBuilder.Entity<VDictionaryWorkEventFinWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Event#FinWork");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.DictionaryValueIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("DictionaryValueID_Code");

                entity.Property(e => e.EventPercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.EventTypeIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.GroupName).HasMaxLength(2000);

                entity.Property(e => e.IsDone).HasColumnName("isDone");

                entity.Property(e => e.Level1).HasMaxLength(50);

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.Name1).HasMaxLength(4000);

                entity.Property(e => e.ParentEventId).HasColumnName("ParentEventID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StageSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VDictionaryWorkEventLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Event#Light");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VDictionaryWorkEventResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Event#Result");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.DictionaryValueIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("DictionaryValueID_Code");

                entity.Property(e => e.EventPercent).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.EventTypeIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.Name1).HasMaxLength(4000);

                entity.Property(e => e.ParentEventId).HasColumnName("ParentEventID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VDictionaryWorkEventRp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Event#RP");

                entity.Property(e => e.EventTypeIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e._2016)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2016");

                entity.Property(e => e._2017)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2017");

                entity.Property(e => e._2018)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2018");

                entity.Property(e => e._2019)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2019");

                entity.Property(e => e._2020)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2020");

                entity.Property(e => e._2021)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2021");

                entity.Property(e => e._2022)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2022");

                entity.Property(e => e._2023)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2023");

                entity.Property(e => e._2024)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2024");

                entity.Property(e => e._2025)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2025");
            });

            modelBuilder.Entity<VDictionaryWorkEventSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#EventSum");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.DictionaryValueIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("DictionaryValueID_Code");

                entity.Property(e => e.DistSum).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

                entity.Property(e => e.EventTypeIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.GroupName).HasMaxLength(260);

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Name1).HasMaxLength(2000);

                entity.Property(e => e.ParentEventId).HasColumnName("ParentEventID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VDictionaryWorkEventTechnic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Event#Technic");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TechnicId).HasColumnName("TechnicID");

                entity.Property(e => e.TechnicIdCode)
                    .HasMaxLength(255)
                    .HasColumnName("TechnicID_Code");
            });

            modelBuilder.Entity<VDictionaryWorkEventUndo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Event#Undo");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsDate).HasColumnType("datetime");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.ValueAfter).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValueBefore).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryWorkFinInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#FinInfo");

                entity.Property(e => e.Code).HasMaxLength(260);

                entity.Property(e => e.Dwrid).HasColumnName("DWRID");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SumParam).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VDictionaryWorkFinPivot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#FinPivot");

                entity.Property(e => e.AllSumm).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Code).HasMaxLength(260);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e._2015)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2015");

                entity.Property(e => e._2016)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2016");

                entity.Property(e => e._2017)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2017");

                entity.Property(e => e._2018)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2018");

                entity.Property(e => e._2019)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2019");

                entity.Property(e => e._2020)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2020");

                entity.Property(e => e._2021)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2021");

                entity.Property(e => e._2022)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2022");

                entity.Property(e => e._2023)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2023");

                entity.Property(e => e._2024)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2024");

                entity.Property(e => e._2025)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2025");
            });

            modelBuilder.Entity<VDictionaryWorkLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Light");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PrintName).HasMaxLength(1000);

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VDictionaryWorkOlap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#OLAP");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.KindIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("KindID_Code");

                entity.Property(e => e.Level1)
                    .HasMaxLength(311)
                    .HasColumnName("level1");

                entity.Property(e => e.Level2)
                    .HasMaxLength(50)
                    .HasColumnName("level2");

                entity.Property(e => e.Level3).HasMaxLength(50);

                entity.Property(e => e.Level4).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PrintName).HasMaxLength(1000);

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkCode_Code");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VDictionaryWorkParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Param");

                entity.Property(e => e.CalculateTypeCode)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("CalculateType_Code");

                entity.Property(e => e.DefaultValueD1).HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultValueD2).HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultValueS).HasMaxLength(2000);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Format)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Formula).HasMaxLength(260);

                entity.Property(e => e.LinkFieldId).HasColumnName("LinkFieldID");

                entity.Property(e => e.LinkFieldIdAttFieldName)
                    .HasMaxLength(50)
                    .HasColumnName("LinkFieldID_AttFieldName");

                entity.Property(e => e.LinkFieldIdAttName)
                    .HasMaxLength(160)
                    .HasColumnName("LinkFieldID_AttName");

                entity.Property(e => e.LinkFieldIdCode)
                    .HasMaxLength(100)
                    .HasColumnName("LinkFieldID_Code");

                entity.Property(e => e.LinkSectionId).HasColumnName("LinkSectionID");

                entity.Property(e => e.LinkSectionIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("LinkSectionID_Code");

                entity.Property(e => e.LinkTypeCode)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("LinkType_Code");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ParamID_Code");

                entity.Property(e => e.ParamIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("ParamID_Name");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcedureName).HasMaxLength(260);

                entity.Property(e => e.SortNum).HasMaxLength(260);

                entity.Property(e => e.TitleName).HasMaxLength(260);
            });

            modelBuilder.Entity<VDictionaryWorkProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Project");

                entity.Property(e => e.BaseRank).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.FinSum).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.FinSum1).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.FinSum2).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority3).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SystemName).HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode).HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryWorkRelation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Relation");

                entity.Property(e => e.DrRid).HasColumnName("DR_RID");

                entity.Property(e => e.DwinCode)
                    .HasMaxLength(50)
                    .HasColumnName("DWIN_Code");

                entity.Property(e => e.DwinDateFrom).HasColumnName("DWIN_DateFrom");

                entity.Property(e => e.DwinDateTo).HasColumnName("DWIN_DateTo");

                entity.Property(e => e.DwinRid).HasColumnName("DWIN_RID");

                entity.Property(e => e.DwoutCode)
                    .HasMaxLength(50)
                    .HasColumnName("DWOUT_Code");

                entity.Property(e => e.DwoutDateFrom).HasColumnName("DWOUT_DateFrom");

                entity.Property(e => e.DwoutDateTo).HasColumnName("DWOUT_DateTo");

                entity.Property(e => e.DwoutRid).HasColumnName("DWOUT_RID");

                entity.Property(e => e.InParentId).HasColumnName("IN_ParentID");

                entity.Property(e => e.OutParentId).HasColumnName("OUT_ParentID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryWorkRiskEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Risk#Event");

                entity.Property(e => e.DamageValueR).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DamageValueS).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DamageValueT).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DictionaryRiskId).HasColumnName("DictionaryRiskID");

                entity.Property(e => e.DictionaryRiskIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DictionaryRiskID_Code");

                entity.Property(e => e.DictionaryRiskIdName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("DictionaryRiskID_Name");

                entity.Property(e => e.DictionaryRiskTypeId).HasColumnName("DictionaryRiskTypeID");

                entity.Property(e => e.DictionaryRiskTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("DictionaryRiskTypeID_Code");

                entity.Property(e => e.DictionaryRiskTypeIdName)
                    .HasMaxLength(260)
                    .HasColumnName("DictionaryRiskTypeID_Name");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.R12).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R13).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R21).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R23).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R31).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R32).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RiskValueDescription)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RiskValue_Description");

                entity.Property(e => e.ValueCount).HasColumnName("Value_Count");

                entity.Property(e => e.ValueP).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryWorkRiskEventCalc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Risk#Event#Calc");

                entity.Property(e => e.DamageValueR).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DamageValueS).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DamageValueT).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.DictionaryRiskId).HasColumnName("DictionaryRiskID");

                entity.Property(e => e.DictionaryRiskIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DictionaryRiskID_Code");

                entity.Property(e => e.DictionaryRiskIdName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("DictionaryRiskID_Name");

                entity.Property(e => e.DictionaryRiskTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("DictionaryRiskTypeID_Code");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ValueP).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryWorkRp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#RP");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.FinDirectionCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("FinDirection_Code");

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.KindIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("KindID_Code");

                entity.Property(e => e.Level1)
                    .HasMaxLength(311)
                    .HasColumnName("level1");

                entity.Property(e => e.Level2)
                    .HasMaxLength(50)
                    .HasColumnName("level2");

                entity.Property(e => e.Level3).HasMaxLength(50);

                entity.Property(e => e.Level4).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(50)
                    .HasColumnName("Section_Code");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionIdCode).HasColumnName("SectionID_Code");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.StageCode)
                    .HasMaxLength(50)
                    .HasColumnName("Stage_Code");

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.StageIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("StageID_Code");

                entity.Property(e => e.StagePercent).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.StageValue).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkCode_Code");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VDictionaryWorkStage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Stage");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDictionaryWorkStructure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDictionary#Work#Structure");

                entity.Property(e => e.Code).HasMaxLength(260);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VDocumentExportHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDocument#ExportHistory");

                entity.Property(e => e.AgentFromId).HasColumnName("AgentFromID");

                entity.Property(e => e.AgentFromIdCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AgentFromID_Code");

                entity.Property(e => e.AgentFromIdName)
                    .HasMaxLength(260)
                    .IsUnicode(false)
                    .HasColumnName("AgentFromID_Name");

                entity.Property(e => e.AgentToId).HasColumnName("AgentToID");

                entity.Property(e => e.AgentToIdCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AgentToID_Code");

                entity.Property(e => e.AgentToIdName)
                    .HasMaxLength(260)
                    .IsUnicode(false)
                    .HasColumnName("AgentToID_Name");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.Email)
                    .HasMaxLength(260)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.ExportDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(260)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VDocumentRelation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDocument#Relation");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.EntryIdin).HasColumnName("EntryIDIn");

                entity.Property(e => e.EntryIdinName)
                    .HasMaxLength(260)
                    .HasColumnName("EntryIDIn_Name");

                entity.Property(e => e.EntryIdinSystemName)
                    .HasMaxLength(160)
                    .HasColumnName("EntryIDIn_SystemName");

                entity.Property(e => e.EntryIdout).HasColumnName("EntryIDOut");

                entity.Property(e => e.EntryIdoutName)
                    .HasMaxLength(260)
                    .HasColumnName("EntryIDOut_Name");

                entity.Property(e => e.EntryIdoutSystemName)
                    .HasMaxLength(160)
                    .HasColumnName("EntryIDOut_SystemName");

                entity.Property(e => e.Koeff1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VDshbChrt14>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#14");

                entity.Property(e => e.ParamCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Param_Code");

                entity.Property(e => e.ParamShortName)
                    .HasMaxLength(260)
                    .HasColumnName("Param_ShortName");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(50)
                    .HasColumnName("Project_Code");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(1000)
                    .HasColumnName("Project_Name");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("Version_Name");
            });

            modelBuilder.Entity<VDshbChrt15>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#15");

                entity.Property(e => e.ParamCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Param_Code");

                entity.Property(e => e.ParamShortName)
                    .HasMaxLength(260)
                    .HasColumnName("Param_ShortName");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(50)
                    .HasColumnName("Project_Code");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(1000)
                    .HasColumnName("Project_Name");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("Version_Name");

                entity.Property(e => e.WorkCode)
                    .HasMaxLength(50)
                    .HasColumnName("Work_Code");

                entity.Property(e => e.WorkName)
                    .HasMaxLength(1000)
                    .HasColumnName("Work_Name");

                entity.Property(e => e.WorkShortName)
                    .HasMaxLength(260)
                    .HasColumnName("Work_ShortName");
            });

            modelBuilder.Entity<VDshbChrt16>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#16");

                entity.Property(e => e.ParamCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Param_Code");

                entity.Property(e => e.ParamShortName)
                    .HasMaxLength(260)
                    .HasColumnName("Param_ShortName");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("Version_Name");

                entity.Property(e => e.WorkCode)
                    .HasMaxLength(50)
                    .HasColumnName("Work_Code");

                entity.Property(e => e.WorkName)
                    .HasMaxLength(2000)
                    .HasColumnName("Work_Name");
            });

            modelBuilder.Entity<VDshbChrt17>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#17");

                entity.Property(e => e.CriterionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Criterion_Code");

                entity.Property(e => e.CriterionFullName)
                    .IsRequired()
                    .HasMaxLength(1053)
                    .HasColumnName("Criterion_FullName");

                entity.Property(e => e.CriterionName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("Criterion_Name");

                entity.Property(e => e.CriterionValue).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(50)
                    .HasColumnName("Project_Code");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(1000)
                    .HasColumnName("Project_Name");

                entity.Property(e => e.ProjectPriority)
                    .HasColumnType("numeric(18, 8)")
                    .HasColumnName("Project_Priority");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("Version_Name");
            });

            modelBuilder.Entity<VDshbChrt18>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#18");

                entity.Property(e => e.ParamCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Param_Code");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("Param_Name");

                entity.Property(e => e.ParamShortName)
                    .HasMaxLength(260)
                    .HasColumnName("Param_ShortName");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("Version_Name");
            });

            modelBuilder.Entity<VDshbChrt20>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#20");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Group_Code");

                entity.Property(e => e.Num).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Object_Type");

                entity.Property(e => e.TotalCount).HasColumnName("Total_Count");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");
            });

            modelBuilder.Entity<VDshbChrt22>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#22");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(302);

                entity.Property(e => e.Summ).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VDshbChrt23>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#23");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ParamID_Code");

                entity.Property(e => e.PersonName)
                    .HasMaxLength(2000)
                    .HasColumnName("Person_Name");

                entity.Property(e => e.PersonUserName)
                    .HasMaxLength(260)
                    .HasColumnName("Person_UserName");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(50)
                    .HasColumnName("Project_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionParentId).HasColumnName("VersionParentID");
            });

            modelBuilder.Entity<VDshbChrt24>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#24");

                entity.Property(e => e.StageTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("StageTypeID_Code");

                entity.Property(e => e.SumStage).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VDshbChrt251>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#25_1");

                entity.Property(e => e.GostCode)
                    .HasMaxLength(50)
                    .HasColumnName("GOST_Code");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(50)
                    .HasColumnName("Kind_Code");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(464)
                    .HasColumnName("Section_Code");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(50)
                    .HasColumnName("Type_Code");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_code");
            });

            modelBuilder.Entity<VDshbChrt252>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#25_2");

                entity.Property(e => e.GostCode)
                    .HasMaxLength(50)
                    .HasColumnName("GOST_Code");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(50)
                    .HasColumnName("Kind_Code");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(464)
                    .HasColumnName("Section_Code");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(50)
                    .HasColumnName("Type_Code");

                entity.Property(e => e.Value).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");
            });

            modelBuilder.Entity<VDshbChrt253>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#25_3");

                entity.Property(e => e.FinGroup)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.GostCode)
                    .HasMaxLength(50)
                    .HasColumnName("GOST_Code");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(50)
                    .HasColumnName("Kind_Code");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(464)
                    .HasColumnName("Section_Code");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(50)
                    .HasColumnName("Type_Code");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");
            });

            modelBuilder.Entity<VDshbChrt254>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#25_4");

                entity.Property(e => e.GostCode)
                    .HasMaxLength(50)
                    .HasColumnName("GOST_Code");

                entity.Property(e => e.KindCode)
                    .HasMaxLength(50)
                    .HasColumnName("Kind_Code");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(464)
                    .HasColumnName("Section_Code");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(50)
                    .HasColumnName("Type_Code");

                entity.Property(e => e.Value).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");
            });

            modelBuilder.Entity<VDshbChrt28>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#28");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VDshbChrt29>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#29");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SectionPath).HasMaxLength(50);

                entity.Property(e => e.Value).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VDshbChrt30>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDSHB#CHRT#30");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VEconomicEffect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEconomic#Effect");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Sum1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum10).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum4).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum5).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum6).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum7).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum8).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Sum9).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Summ).HasColumnType("numeric(27, 2)");

                entity.Property(e => e.ValueTypeCode)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("ValueType_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.VersionIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Name");
            });

            modelBuilder.Entity<VEconomicEffectProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEconomic#Effect#Project");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(50)
                    .HasColumnName("Project_Code");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(1000)
                    .HasColumnName("Project_Name");

                entity.Property(e => e.ProjectNum)
                    .HasMaxLength(50)
                    .HasColumnName("Project_Num");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VElementForTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vElementForTask");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.DictionaryValueIdCode)
                    .HasMaxLength(255)
                    .HasColumnName("DictionaryValueID_Code");

                entity.Property(e => e.ElementTypeCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Code");

                entity.Property(e => e.ElementTypeName)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Name");

                entity.Property(e => e.ElementValue)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Element_Value");

                entity.Property(e => e.EventTypeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.GroupName).HasMaxLength(2000);

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");
            });

            modelBuilder.Entity<VElementForTaskLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vElementForTask#Light");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VEventMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEvent#Message");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(2000)
                    .HasColumnName("Agent_Code");

                entity.Property(e => e.EventDate).HasColumnType("datetime");

                entity.Property(e => e.EventEndDate).HasColumnType("datetime");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventTypeName)
                    .IsRequired()
                    .HasMaxLength(29)
                    .IsUnicode(false)
                    .HasColumnName("EventType_Name");

                entity.Property(e => e.EventValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.HostName).HasMaxLength(250);

                entity.Property(e => e.IsActual).HasColumnName("isActual");

                entity.Property(e => e.MessageText).IsRequired();

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VExternalFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExternal#File");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.AgentIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("AgentID_Code");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Description)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.DocPref)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryName).HasMaxLength(260);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.InDate).HasColumnType("date");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateSignName)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VExternalFileArmRp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExternal#File#ArmRp");

                entity.Property(e => e.Description)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.DocPref)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fdata)
                    .HasColumnType("image")
                    .HasColumnName("FData");

                entity.Property(e => e.InDate).HasColumnType("date");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VExternalFileArmRpLast>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExternal#File#ArmRp#Last");

                entity.Property(e => e.Description)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.DocPref)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fdata)
                    .HasColumnType("image")
                    .HasColumnName("FData");

                entity.Property(e => e.InDate).HasColumnType("date");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VFinanceLimit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinance#Limit");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.NSum)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum");

                entity.Property(e => e.NSum1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum1");

                entity.Property(e => e.NSum2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum2");

                entity.Property(e => e.NSum3)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum3");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SpecSum).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.VersionIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Name");
            });

            modelBuilder.Entity<VFinanceLimitSpec>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinance#Limit#Spec");

                entity.Property(e => e.ChangeDate).HasColumnType("date");

                entity.Property(e => e.MainSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.NSum)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nSum");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.WorkSectionId).HasColumnName("WorkSectionID");

                entity.Property(e => e.WorkSectionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("WorkSectionID_Code");

                entity.Property(e => e.WorkSectionIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("WorkSectionID_Name");
            });

            modelBuilder.Entity<VFinanceWorkPlaceAltDataHelper>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinanceWorkPlace#Alt#Data#Helper");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ProgNumSort).HasMaxLength(200);

                entity.Property(e => e.Rid2015).HasColumnName("RID2015");

                entity.Property(e => e.Rid2015b).HasColumnName("RID2015b");

                entity.Property(e => e.Rid2016).HasColumnName("RID2016");

                entity.Property(e => e.Rid2016b).HasColumnName("RID2016b");

                entity.Property(e => e.Rid2017).HasColumnName("RID2017");

                entity.Property(e => e.Rid2017b).HasColumnName("RID2017b");

                entity.Property(e => e.Rid2018).HasColumnName("RID2018");

                entity.Property(e => e.Rid2018b).HasColumnName("RID2018b");

                entity.Property(e => e.Rid2019).HasColumnName("RID2019");

                entity.Property(e => e.Rid2019b).HasColumnName("RID2019b");

                entity.Property(e => e.Rid2020).HasColumnName("RID2020");

                entity.Property(e => e.Rid2020b).HasColumnName("RID2020b");

                entity.Property(e => e.Rid2021).HasColumnName("RID2021");

                entity.Property(e => e.Rid2021b).HasColumnName("RID2021b");

                entity.Property(e => e.Rid2022).HasColumnName("RID2022");

                entity.Property(e => e.Rid2022b).HasColumnName("RID2022b");

                entity.Property(e => e.Rid2023).HasColumnName("RID2023");

                entity.Property(e => e.Rid2023b).HasColumnName("RID2023b");

                entity.Property(e => e.Rid2024).HasColumnName("RID2024");

                entity.Property(e => e.Rid2024b).HasColumnName("RID2024b");

                entity.Property(e => e.Rid2025).HasColumnName("RID2025");

                entity.Property(e => e.Rid2025b).HasColumnName("RID2025b");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.Property(e => e._2015)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2015");

                entity.Property(e => e._2015b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2015b");

                entity.Property(e => e._2016)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2016");

                entity.Property(e => e._2016b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2016b");

                entity.Property(e => e._2017)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2017");

                entity.Property(e => e._2017b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2017b");

                entity.Property(e => e._2018)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2018");

                entity.Property(e => e._2018b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2018b");

                entity.Property(e => e._2019)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2019");

                entity.Property(e => e._2019b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2019b");

                entity.Property(e => e._2020)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2020");

                entity.Property(e => e._2020b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2020b");

                entity.Property(e => e._2021)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2021");

                entity.Property(e => e._2021b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2021b");

                entity.Property(e => e._2022)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2022");

                entity.Property(e => e._2022b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2022b");

                entity.Property(e => e._2023)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2023");

                entity.Property(e => e._2023b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2023b");

                entity.Property(e => e._2024)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2024");

                entity.Property(e => e._2024b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2024b");

                entity.Property(e => e._2025)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2025");

                entity.Property(e => e._2025b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2025b");

                entity.Property(e => e.Версия)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.НаименованиеМероприятия)
                    .HasMaxLength(1000)
                    .HasColumnName("Наименование мероприятия");

                entity.Property(e => e.НомерМероприятияВПрограмме)
                    .HasMaxLength(55)
                    .HasColumnName("Номер мероприятия в программе");

                entity.Property(e => e.Подраздел).HasMaxLength(100);

                entity.Property(e => e.Пункт).HasMaxLength(100);

                entity.Property(e => e.Раздел).HasMaxLength(500);

                entity.Property(e => e.РегистрационныйНомерМероприятия)
                    .HasMaxLength(55)
                    .HasColumnName("Регистрационный номер мероприятия");

                entity.Property(e => e.СокрНаименование)
                    .HasMaxLength(1000)
                    .HasColumnName("Сокр. наименование");

                entity.Property(e => e.Статья).HasMaxLength(100);

                entity.Property(e => e.ШифрПроекта)
                    .HasMaxLength(1000)
                    .HasColumnName("Шифр проекта");
            });

            modelBuilder.Entity<VFinanceWorkPlaceAltDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinanceWorkPlace#Alt#Data");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ProgNumSort).HasMaxLength(200);

                entity.Property(e => e.Rid2015).HasColumnName("RID2015");

                entity.Property(e => e.Rid2015b).HasColumnName("RID2015b");

                entity.Property(e => e.Rid2016).HasColumnName("RID2016");

                entity.Property(e => e.Rid2016b).HasColumnName("RID2016b");

                entity.Property(e => e.Rid2017).HasColumnName("RID2017");

                entity.Property(e => e.Rid2017b).HasColumnName("RID2017b");

                entity.Property(e => e.Rid2018).HasColumnName("RID2018");

                entity.Property(e => e.Rid2018b).HasColumnName("RID2018b");

                entity.Property(e => e.Rid2019).HasColumnName("RID2019");

                entity.Property(e => e.Rid2019b).HasColumnName("RID2019b");

                entity.Property(e => e.Rid2020).HasColumnName("RID2020");

                entity.Property(e => e.Rid2020b).HasColumnName("RID2020b");

                entity.Property(e => e.Rid2021).HasColumnName("RID2021");

                entity.Property(e => e.Rid2021b).HasColumnName("RID2021b");

                entity.Property(e => e.Rid2022).HasColumnName("RID2022");

                entity.Property(e => e.Rid2022b).HasColumnName("RID2022b");

                entity.Property(e => e.Rid2023).HasColumnName("RID2023");

                entity.Property(e => e.Rid2023b).HasColumnName("RID2023b");

                entity.Property(e => e.Rid2024).HasColumnName("RID2024");

                entity.Property(e => e.Rid2024b).HasColumnName("RID2024b");

                entity.Property(e => e.Rid2025).HasColumnName("RID2025");

                entity.Property(e => e.Rid2025b).HasColumnName("RID2025b");

                entity.Property(e => e.Rrid).HasColumnName("RRID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.Property(e => e._2015)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2015");

                entity.Property(e => e._2015b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2015b");

                entity.Property(e => e._2016)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2016");

                entity.Property(e => e._2016b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2016b");

                entity.Property(e => e._2017)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2017");

                entity.Property(e => e._2017b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2017b");

                entity.Property(e => e._2018)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2018");

                entity.Property(e => e._2018b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2018b");

                entity.Property(e => e._2019)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2019");

                entity.Property(e => e._2019b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2019b");

                entity.Property(e => e._2020)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2020");

                entity.Property(e => e._2020b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2020b");

                entity.Property(e => e._2021)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2021");

                entity.Property(e => e._2021b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2021b");

                entity.Property(e => e._2022)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2022");

                entity.Property(e => e._2022b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2022b");

                entity.Property(e => e._2023)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2023");

                entity.Property(e => e._2023b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2023b");

                entity.Property(e => e._2024)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2024");

                entity.Property(e => e._2024b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2024b");

                entity.Property(e => e._2025)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2025");

                entity.Property(e => e._2025b)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("2025b");

                entity.Property(e => e.Версия)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.НаименованиеМероприятия)
                    .HasMaxLength(1000)
                    .HasColumnName("Наименование мероприятия");

                entity.Property(e => e.НомерМероприятияВПрограмме)
                    .HasMaxLength(55)
                    .HasColumnName("Номер мероприятия в программе");

                entity.Property(e => e.Подраздел).HasMaxLength(100);

                entity.Property(e => e.Пункт).HasMaxLength(100);

                entity.Property(e => e.Раздел).HasMaxLength(500);

                entity.Property(e => e.РегистрационныйНомерМероприятия)
                    .HasMaxLength(55)
                    .HasColumnName("Регистрационный номер мероприятия");

                entity.Property(e => e.СокрНаименование)
                    .HasMaxLength(1000)
                    .HasColumnName("Сокр. наименование");

                entity.Property(e => e.Статья).HasMaxLength(100);

                entity.Property(e => e.ШифрПроекта)
                    .HasMaxLength(1000)
                    .HasColumnName("Шифр проекта");
            });

            modelBuilder.Entity<VFinanceWorkPlaceDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinanceWorkPlace#Data");

                entity.Property(e => e.LimitSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.ProgNumSort).HasMaxLength(200);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.Property(e => e.Версия)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ВидФинансирования)
                    .HasMaxLength(50)
                    .HasColumnName("Вид финансирования");

                entity.Property(e => e.ЗначениеФинансовогоПоказателя)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Значение финансового показателя");

                entity.Property(e => e.ЗначениеФинансовогоПоказателяДо)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Значение финансового показателя до");

                entity.Property(e => e.НаименованиеМероприятия)
                    .HasMaxLength(1000)
                    .HasColumnName("Наименование мероприятия");

                entity.Property(e => e.НомерМероприятияВПрограмме)
                    .HasMaxLength(55)
                    .HasColumnName("Номер мероприятия в программе");

                entity.Property(e => e.Подраздел).HasMaxLength(100);

                entity.Property(e => e.ПоказательФинансированияПоГодам).HasColumnName("Показатель финансирования по годам");

                entity.Property(e => e.Пункт).HasMaxLength(100);

                entity.Property(e => e.Раздел).HasMaxLength(500);

                entity.Property(e => e.РегистрационныйНомерМероприятия)
                    .HasMaxLength(55)
                    .HasColumnName("Регистрационный номер мероприятия");

                entity.Property(e => e.СокрНаименование)
                    .HasMaxLength(1000)
                    .HasColumnName("Сокр. наименование");

                entity.Property(e => e.Статья).HasMaxLength(100);

                entity.Property(e => e.ШифрПроекта)
                    .HasMaxLength(1000)
                    .HasColumnName("Шифр проекта");
            });

            modelBuilder.Entity<VFinancialChartAutomaticKa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinancial#Chart#AutomaticKA");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.SumValue).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkDirectionCode)
                    .HasMaxLength(2000)
                    .HasColumnName("WorkDirection_Code");
            });

            modelBuilder.Entity<VFinancialChartDistributionBudget>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinancial#Chart#DistributionBudget");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectIdCode)
                    .IsRequired()
                    .HasMaxLength(88)
                    .IsUnicode(false)
                    .HasColumnName("ProjectID_Code");

                entity.Property(e => e.SumValue).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkDirectionCode).HasColumnName("WorkDirection_Code");
            });

            modelBuilder.Entity<VFinancialChartMannedFlight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinancial#Chart#MannedFlight");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.SumValue).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkDirectionCode)
                    .HasMaxLength(2000)
                    .HasColumnName("WorkDirection_Code");
            });

            modelBuilder.Entity<VFinancialChartMannedFlightByType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinancial#Chart#MannedFlight#ByType");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("ProjectID_Code");

                entity.Property(e => e.SumValue).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkDirectionCode).HasColumnName("WorkDirection_Code");
            });

            modelBuilder.Entity<VFinancialChartScheduleFinancing>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinancial#Chart#ScheduleFinancing");

                entity.Property(e => e.SumValue).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Work_Code");
            });

            modelBuilder.Entity<VFinancialChartScheduleFinancingAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinancial#Chart#ScheduleFinancingAll");

                entity.Property(e => e.SumValue).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VFinancialChartTransport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinancial#Chart#Transport");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.SumValue).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkDirectionCode)
                    .HasMaxLength(2000)
                    .HasColumnName("WorkDirection_Code");
            });

            modelBuilder.Entity<VFinancialManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFinancial#Management");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Executor).HasMaxLength(2000);

                entity.Property(e => e.KindIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("KindID_Code");

                entity.Property(e => e.Level1).HasMaxLength(311);

                entity.Property(e => e.Level2).HasMaxLength(50);

                entity.Property(e => e.Level3).HasMaxLength(50);

                entity.Property(e => e.Level4).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SectionIdCode)
                    .HasMaxLength(311)
                    .HasColumnName("SectionID_Code");

                entity.Property(e => e.SectionIdName)
                    .HasMaxLength(50)
                    .HasColumnName("SectionID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e._2016).HasColumnType("numeric(38, 4)");

                entity.Property(e => e._2016Vb)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("_2016_VB");

                entity.Property(e => e._2017).HasColumnType("numeric(38, 4)");

                entity.Property(e => e._2017Vb)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("_2017_VB");

                entity.Property(e => e._2018).HasColumnType("numeric(38, 4)");

                entity.Property(e => e._2018Vb)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("_2018_VB");

                entity.Property(e => e._2019).HasColumnType("numeric(38, 4)");

                entity.Property(e => e._2019Vb)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("_2019_VB");

                entity.Property(e => e._2020).HasColumnType("numeric(38, 4)");

                entity.Property(e => e._2020Vb)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("_2020_VB");

                entity.Property(e => e._2021).HasColumnType("numeric(38, 4)");

                entity.Property(e => e._2021Vb)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("_2021_VB");

                entity.Property(e => e._2022).HasColumnType("numeric(38, 4)");

                entity.Property(e => e._2022Vb)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("_2022_VB");

                entity.Property(e => e._2023).HasColumnType("numeric(38, 4)");

                entity.Property(e => e._2023Vb)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("_2023_VB");

                entity.Property(e => e._2024).HasColumnType("numeric(38, 4)");

                entity.Property(e => e._2024Vb)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("_2024_VB");

                entity.Property(e => e._2025).HasColumnType("numeric(38, 4)");

                entity.Property(e => e._2025Vb)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("_2025_VB");
            });

            modelBuilder.Entity<VGlobalGlobalEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGlobal#GlobalEntry");

                entity.Property(e => e.ClassLib).HasMaxLength(250);

                entity.Property(e => e.ClassName).HasMaxLength(250);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.ComplexName).HasMaxLength(423);

                entity.Property(e => e.EntryRid).HasColumnName("EntryRID");

                entity.Property(e => e.GlobalEntryAttrRid).HasColumnName("GlobalEntryAttr_RID");

                entity.Property(e => e.IsOnlyChildUse).HasColumnName("isOnlyChildUse");

                entity.Property(e => e.IsRelation).HasColumnName("isRelation");

                entity.Property(e => e.IsSystem).HasColumnName("isSystem");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<VGlobalGlobalEntryAttr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGlobal#GlobalEntryAttr");

                entity.Property(e => e.AttCaption).HasMaxLength(100);

                entity.Property(e => e.AttFieldName).HasMaxLength(50);

                entity.Property(e => e.AttGroup).HasMaxLength(100);

                entity.Property(e => e.AttName).HasMaxLength(160);

                entity.Property(e => e.AttType).HasMaxLength(20);

                entity.Property(e => e.ClassLib).HasMaxLength(250);

                entity.Property(e => e.ClassName).HasMaxLength(250);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryName).HasMaxLength(423);

                entity.Property(e => e.EntryRid).HasColumnName("EntryRID");

                entity.Property(e => e.GlobalEntryAttrRid).HasColumnName("GlobalEntryAttr_RID");

                entity.Property(e => e.GlobalName).HasMaxLength(524);

                entity.Property(e => e.IsOnlyChildUse).HasColumnName("isOnlyChildUse");

                entity.Property(e => e.IsRelation).HasColumnName("isRelation");

                entity.Property(e => e.IsSystem).HasColumnName("isSystem");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<VGlobalGlobalEntryList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGlobal#GlobalEntry#List");

                entity.Property(e => e.ClassLib).HasMaxLength(250);

                entity.Property(e => e.ClassName).HasMaxLength(250);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.ComplexName).HasMaxLength(423);

                entity.Property(e => e.EditClassName).HasMaxLength(250);

                entity.Property(e => e.IsOnlyChildUse).HasColumnName("isOnlyChildUse");

                entity.Property(e => e.IsRelation).HasColumnName("isRelation");

                entity.Property(e => e.IsSystem).HasColumnName("isSystem");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SystemName).HasMaxLength(160);

                entity.Property(e => e.TypeEntry)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VGlobalGlobalEntryListRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGlobal#GlobalEntry#List#Role");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RoleName).HasMaxLength(260);
            });

            modelBuilder.Entity<VGroupParamGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGroupParam#Group");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VGroupParamParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGroupParam#Param");

                entity.Property(e => e.Formula).HasMaxLength(260);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ParamID_Code");

                entity.Property(e => e.ParamIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("ParamID_Name");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VGroupWorkGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGroupWork#Group");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VGroupWorkWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vGroupWork#Work");

                entity.Property(e => e.Formula).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.WorkCode)
                    .HasMaxLength(50)
                    .HasColumnName("Work_Code");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.Property(e => e.WorkIdCode)
                    .HasMaxLength(1000)
                    .HasColumnName("WorkID_Code");
            });

            modelBuilder.Entity<VHistoryState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vHistory#State");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.AgentIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("AgentID_Code");

                entity.Property(e => e.AgentIdName)
                    .HasMaxLength(260)
                    .HasColumnName("AgentID_Name");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserName).HasMaxLength(260);
            });

            modelBuilder.Entity<VIntObligationIntObligation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vIntObligation#IntObligation");

                entity.Property(e => e.GroupName).HasMaxLength(50);

                entity.Property(e => e.InSum).HasColumnName("inSum");

                entity.Property(e => e.IsPlan).HasColumnName("isPlan");

                entity.Property(e => e.ProgName).HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkName).HasMaxLength(250);
            });

            modelBuilder.Entity<VMmWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMM#Work");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.RankParam1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RankParam2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RankParam3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RankParam4).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RapidKoefName)
                    .HasMaxLength(27)
                    .IsUnicode(false)
                    .HasColumnName("RapidKoef_Name");

                entity.Property(e => e.RapidKoefValue)
                    .HasColumnType("numeric(3, 2)")
                    .HasColumnName("RapidKoef_Value");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.StageIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("StageID_Code");

                entity.Property(e => e.StageIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("StageID_Name");
            });

            modelBuilder.Entity<VMmWorkGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMM#Work#Group");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VMmWorkGroupPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMM#Work#Group#Person");

                entity.Property(e => e.GroupRoleName)
                    .IsRequired()
                    .HasMaxLength(38)
                    .IsUnicode(false)
                    .HasColumnName("GroupRole_Name");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VMmWorkPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMM#Work#Person");

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Department_Code");

                entity.Property(e => e.GroupRoleName)
                    .HasMaxLength(250)
                    .HasColumnName("GroupRole_Name");

                entity.Property(e => e.ManagerCode)
                    .HasMaxLength(2000)
                    .HasColumnName("Manager_Code");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Param1Name)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Param1_Name");

                entity.Property(e => e.Param1Value)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("Param1_Value");

                entity.Property(e => e.Param2Name)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Param2_Name");

                entity.Property(e => e.Param2Value)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("Param2_Value");

                entity.Property(e => e.Param3Name)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Param3_Name");

                entity.Property(e => e.Param3Value)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("Param3_Value");

                entity.Property(e => e.Param4Name)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Param4_Name");

                entity.Property(e => e.Param4Value)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("Param4_Value");

                entity.Property(e => e.ParamNote)
                    .HasMaxLength(2000)
                    .HasColumnName("Param_Note");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .HasColumnName("Post_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VMmWorkPersonContribution>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMM#Work#Person#Contribution");

                entity.Property(e => e.CalcDate).HasColumnType("date");

                entity.Property(e => e.ContributionValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GroupRoleName)
                    .HasMaxLength(250)
                    .HasColumnName("GroupRole_Name");

                entity.Property(e => e.PersonCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("Person_Code");

                entity.Property(e => e.PersonDepartment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Person_Department");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonPost)
                    .HasMaxLength(260)
                    .HasColumnName("Person_Post");

                entity.Property(e => e.PersonRaiting).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StageDateFrom)
                    .HasColumnType("date")
                    .HasColumnName("Stage_DateFrom");

                entity.Property(e => e.StageDateTo)
                    .HasColumnType("date")
                    .HasColumnName("Stage_DateTo");

                entity.Property(e => e.StageId).HasColumnName("StageID");
            });

            modelBuilder.Entity<VMmWorkPersonParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMM#Work#Person#Param");

                entity.Property(e => e.AgentIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AgentID_Code");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Param1Name)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Param1_Name");

                entity.Property(e => e.Param1Value)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("Param1_Value");

                entity.Property(e => e.Param2Name)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Param2_Name");

                entity.Property(e => e.Param2Value)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("Param2_Value");

                entity.Property(e => e.Param3Name)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Param3_Name");

                entity.Property(e => e.Param3Value)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("Param3_Value");

                entity.Property(e => e.Param4Name)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Param4_Name");

                entity.Property(e => e.Param4Value)
                    .HasColumnType("numeric(2, 1)")
                    .HasColumnName("Param4_Value");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VMmWorkStage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMM#Work#Stage");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VObjectPriorityCriterion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vObject#PriorityCriterion");

                entity.Property(e => e.CalcDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(50)
                    .HasColumnName("Category_Code");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(260)
                    .HasColumnName("Category_Name");

                entity.Property(e => e.CriterionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Criterion_Code");

                entity.Property(e => e.CriterionDescription)
                    .HasMaxLength(2000)
                    .HasColumnName("Criterion_Description");

                entity.Property(e => e.CriterionId).HasColumnName("CriterionID");

                entity.Property(e => e.CriterionIdCode)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("CriterionID_Code");

                entity.Property(e => e.CriterionValue).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamValue).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.RankValue).HasColumnType("numeric(37, 16)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ValueN1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValueN2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValueN3).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VObjectPriorityRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vObjectPriority#Rank");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(2000)
                    .HasColumnName("Agent_Code");

                entity.Property(e => e.NRankValue).HasColumnName("nRankValue");

                entity.Property(e => e.NValue)
                    .HasColumnType("numeric(3, 2)")
                    .HasColumnName("nValue");

                entity.Property(e => e.ObjectId1).HasColumnName("ObjectID1");

                entity.Property(e => e.ObjectId2).HasColumnName("ObjectID2");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.RankValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SValue)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sValue");

                entity.Property(e => e.ValueRid).HasColumnName("ValueRID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VObjectiveObjective>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vObjective#Objective");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SystemName).HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VOrbitalGroupDataOlap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vOrbitalGroup#Data#OLAP");

                entity.Property(e => e.BoosterIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("BoosterID_Code");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.ClassRnCode)
                    .HasMaxLength(50)
                    .HasColumnName("ClassRN_Code");

                entity.Property(e => e.FlightModel)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.NCount).HasColumnName("nCount");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.ObtekatelIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("ObtekatelID_Code");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RocketIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("RocketID_Code");

                entity.Property(e => e.SpaceLaunchIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("SpaceLaunchID_Code");

                entity.Property(e => e.SpaceLaunchSetIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("SpaceLaunchSetID_Code");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.SpacecraftIdCode)
                    .HasMaxLength(500)
                    .HasColumnName("SpacecraftID_Code");
            });

            modelBuilder.Entity<VOrbitalGroupVariant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vOrbitalGroup#Variant");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateModify).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VOrganization>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vOrganization");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.AgentIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("AgentID_Code");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VParamParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vParam#Param");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DataTypeCode)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("DataType_Code");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Formula).HasMaxLength(260);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("GroupID_Code");

                entity.Property(e => e.LinkFieldId).HasColumnName("LinkFieldID");

                entity.Property(e => e.LinkSectionId).HasColumnName("LinkSectionID");

                entity.Property(e => e.LinkfieldidAttcaption)
                    .HasMaxLength(100)
                    .HasColumnName("LINKFIELDID_ATTCAPTION");

                entity.Property(e => e.LinkfieldidAttfieldname)
                    .HasMaxLength(50)
                    .HasColumnName("LINKFIELDID_ATTFIELDNAME");

                entity.Property(e => e.LinkfieldidAttname)
                    .HasMaxLength(160)
                    .HasColumnName("LINKFIELDID_ATTNAME");

                entity.Property(e => e.LinksectionidCode)
                    .HasMaxLength(50)
                    .HasColumnName("LINKSECTIONID_CODE");

                entity.Property(e => e.LinksectionidName)
                    .HasMaxLength(260)
                    .HasColumnName("LINKSECTIONID_NAME");

                entity.Property(e => e.LinktypeName)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("LINKTYPE_NAME");

                entity.Property(e => e.MeasureId).HasColumnName("MeasureID");

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcedureId).HasColumnName("ProcedureID");

                entity.Property(e => e.ProcedureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("ProcedureID_Code");

                entity.Property(e => e.ProcedureIdProcedurename)
                    .HasMaxLength(260)
                    .HasColumnName("ProcedureID_PROCEDURENAME");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);
            });

            modelBuilder.Entity<VParamValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vParam#Value");

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.LinkText).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ValueD1).HasColumnType("smalldatetime");

                entity.Property(e => e.ValueD2).HasColumnType("smalldatetime");

                entity.Property(e => e.ValueN1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValueN2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VPostDuty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPost#Duty");

                entity.Property(e => e.Name)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VPostPost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPost#Post");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.CategoryIdName)
                    .HasMaxLength(260)
                    .HasColumnName("CategoryID_Name");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(50)
                    .HasColumnName("Department_Code");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("DepartmentID_Code");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);
            });

            modelBuilder.Entity<VPriorityCriterionObject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPriorityCriterion#Object");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("Version_Name");

                entity.Property(e => e.VersionStateId).HasColumnName("Version_StateID");

                entity.Property(e => e.VersionStateName)
                    .IsRequired()
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("Version_StateName");
            });

            modelBuilder.Entity<VPriorityCriterionRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPriorityCriterion#Rank");

                entity.Property(e => e.Criterion1Id).HasColumnName("Criterion1ID");

                entity.Property(e => e.Criterion2Id).HasColumnName("Criterion2ID");

                entity.Property(e => e.PersonCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("Person_Code");

                entity.Property(e => e.PersonDepartment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Person_Department");

                entity.Property(e => e.PersonFirstName)
                    .HasMaxLength(260)
                    .HasColumnName("Person_FirstName");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.PersonLastName)
                    .HasMaxLength(260)
                    .HasColumnName("Person_LastName");

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("Person_Name");

                entity.Property(e => e.PersonPatronymic)
                    .HasMaxLength(260)
                    .HasColumnName("Person_Patronymic");

                entity.Property(e => e.PersonPost)
                    .HasMaxLength(50)
                    .HasColumnName("Person_Post");

                entity.Property(e => e.RankValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VPriorityCriterionScale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPriorityCriterion#Scale");

                entity.Property(e => e.CriterionValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamValueFrom).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ParamValueTo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ScaleName)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<VPriorityCriterionValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPriorityCriterion#Value");

                entity.Property(e => e.CriterionId).HasColumnName("CriterionID");

                entity.Property(e => e.CriterionValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VProjectPriorityDshb01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProject#Priority#DSHB#01");

                entity.Property(e => e.BaseRank).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Median).HasColumnType("numeric(38, 8)");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionState)
                    .IsRequired()
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("Version_State");
            });

            modelBuilder.Entity<VProjectProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProject#Project");

                entity.Property(e => e.AllowableSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BaseRank).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.EconomicEffectCode)
                    .HasMaxLength(2000)
                    .HasColumnName("EconomicEffect_Code");

                entity.Property(e => e.FinSum).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.FinSum1).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.FinSum2).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.LaborCost).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PercentSum).HasColumnType("numeric(38, 16)");

                entity.Property(e => e.Priority2).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Priority3).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.ProjectUser).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RiskValueR)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R");

                entity.Property(e => e.SystemName).HasMaxLength(50);

                entity.Property(e => e.TargetIndicatorCode)
                    .HasMaxLength(2000)
                    .HasColumnName("TargetIndicator_Code");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode).HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkDirectionCode)
                    .HasMaxLength(2000)
                    .HasColumnName("WorkDirection_Code");
            });

            modelBuilder.Entity<VProjectTargetIndicator>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProject#TargetIndicator");

                entity.Property(e => e.IndicatorId).HasColumnName("IndicatorID");

                entity.Property(e => e.IndicatorIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("IndicatorID_Code");

                entity.Property(e => e.IndicatorIdName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("IndicatorID_Name");

                entity.Property(e => e.Koeff).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(250);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VProjectUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProject#User");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProjectIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("ProjectID_Code");

                entity.Property(e => e.ProjectIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("ProjectID_Name");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RoleIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RoleID_Code");

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("UserID_Code");
            });

            modelBuilder.Entity<VPurposePurpose>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPurpose#Purpose");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SystemName).HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VRiskAvailableCalculatedValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRisk#AvailableCalculatedValue");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.CalcDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActual).HasColumnName("isActual");

                entity.Property(e => e.IsBasic).HasColumnName("isBasic");

                entity.Property(e => e.IsManual).HasColumnName("isManual");

                entity.Property(e => e.ItemCode).HasMaxLength(260);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ParamID_Code");

                entity.Property(e => e.PersonName)
                    .HasMaxLength(2000)
                    .HasColumnName("Person_Name");

                entity.Property(e => e.PersonUserName)
                    .HasMaxLength(260)
                    .HasColumnName("Person_UserName");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectIdNum)
                    .HasMaxLength(50)
                    .HasColumnName("ProjectID_Num");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VRiskDamageValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRisk#Damage#Value");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<VRiskEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRisk#Event");

                entity.Property(e => e.BaseEvent).HasMaxLength(2000);

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryRiskId).HasColumnName("DictionaryRiskID");

                entity.Property(e => e.DictionaryRiskIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DictionaryRiskID_Code");

                entity.Property(e => e.DictionaryRiskIdName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("DictionaryRiskID_Name");

                entity.Property(e => e.DictionaryRiskTypeCode)
                    .HasMaxLength(50)
                    .HasColumnName("DictionaryRiskType_Code");

                entity.Property(e => e.DictionaryRiskTypeName)
                    .HasMaxLength(260)
                    .HasColumnName("DictionaryRiskType_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.VersionIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Name");
            });

            modelBuilder.Entity<VRiskEventProbabilityValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRisk#Event#Probability#Value");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");
            });

            modelBuilder.Entity<VRiskEventValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRisk#Event#Value");

                entity.Property(e => e.DamageCharR).HasMaxLength(300);

                entity.Property(e => e.DamageCharS).HasMaxLength(300);

                entity.Property(e => e.DamageCharT).HasMaxLength(300);

                entity.Property(e => e.DamageValueR).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DamageValueS).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DamageValueT).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(50)
                    .HasColumnName("Department_Code");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(260)
                    .HasColumnName("Department_Name");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.PersonUserName)
                    .HasMaxLength(260)
                    .HasColumnName("Person_UserName");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .HasColumnName("Post_Code");

                entity.Property(e => e.PostName)
                    .HasMaxLength(260)
                    .HasColumnName("Post_Name");

                entity.Property(e => e.ProffKoef).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RiskValueDescription)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RiskValue_Description");

                entity.Property(e => e.TabNum).HasMaxLength(50);

                entity.Property(e => e.ValueP).HasColumnType("numeric(38, 6)");
            });

            modelBuilder.Entity<VRiskEventValueDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRisk#Event#Value#Detail");

                entity.Property(e => e.DictionaryRiskCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DictionaryRisk_Code");

                entity.Property(e => e.DictionaryRiskId).HasColumnName("DictionaryRiskID");

                entity.Property(e => e.DictionaryRiskName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("DictionaryRisk_Name");

                entity.Property(e => e.DictionaryRiskTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("DictionaryRiskTypeID_Code");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSchedulerAppointment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vScheduler#Appointment");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IsPrivate).HasColumnName("isPrivate");

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(128)
                    .HasColumnName("OwnerID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<VSpaceLaunchSet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaceLaunch#Set");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.ClassRnCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClassRN_Code");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MinimumDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Note).HasMaxLength(806);

                entity.Property(e => e.ObRid).HasColumnName("ObRID");

                entity.Property(e => e.ObRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("ObRID_Code");

                entity.Property(e => e.ObRidName)
                    .HasMaxLength(260)
                    .HasColumnName("ObRID_Name");

                entity.Property(e => e.ObStateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("ObStateID_Code");

                entity.Property(e => e.ObTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("ObTypeID_Code");

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.RbRid).HasColumnName("RbRID");

                entity.Property(e => e.RbRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("RbRID_Code");

                entity.Property(e => e.RbRidName)
                    .HasMaxLength(260)
                    .HasColumnName("RbRID_Name");

                entity.Property(e => e.RbStateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("RbStateID_Code");

                entity.Property(e => e.RbTypeId).HasColumnName("RbTypeID");

                entity.Property(e => e.RbTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("RbTypeID_Code");

                entity.Property(e => e.RbTypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("RbTypeID_Name");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RnRid).HasColumnName("RnRID");

                entity.Property(e => e.RnRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("RnRID_Code");

                entity.Property(e => e.RnRidName)
                    .HasMaxLength(260)
                    .HasColumnName("RnRID_Name");

                entity.Property(e => e.RnStateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("RnStateID_Code");

                entity.Property(e => e.RnTypeId).HasColumnName("RnTypeID");

                entity.Property(e => e.RnTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("RnTypeID_Code");

                entity.Property(e => e.RnTypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("RnTypeID_Name");

                entity.Property(e => e.SlRid).HasColumnName("SlRID");

                entity.Property(e => e.SlRidCode)
                    .HasMaxLength(260)
                    .HasColumnName("SlRID_Code");

                entity.Property(e => e.SlRidName)
                    .HasMaxLength(260)
                    .HasColumnName("SlRID_Name");

                entity.Property(e => e.StorageExpirationDateOb)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("StorageExpirationDateOB");

                entity.Property(e => e.StorageExpirationDateRb)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("StorageExpirationDateRB");

                entity.Property(e => e.StorageExpirationDateRn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("StorageExpirationDateRN");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VSpaceLaunchSetGetKa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaceLaunch#Set#GetKA");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SpaceportId).HasColumnName("SpaceportID");

                entity.Property(e => e.TypeKaid).HasColumnName("TypeKAID");

                entity.Property(e => e.TypeRbid).HasColumnName("TypeRBID");

                entity.Property(e => e.TypeRnid).HasColumnName("TypeRNID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VSpaceLaunchSetGetOb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaceLaunch#Set#GetOB");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ObRid).HasColumnName("ObRID");

                entity.Property(e => e.RbRid).HasColumnName("RbRID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RnRid).HasColumnName("RnRID");

                entity.Property(e => e.SpaceportId).HasColumnName("SpaceportID");

                entity.Property(e => e.TypeRbid).HasColumnName("TypeRBID");

                entity.Property(e => e.TypeRnid).HasColumnName("TypeRNID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VSpaceLaunchSetGetRb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaceLaunch#Set#GetRB");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.RbRid).HasColumnName("RbRID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RnRid).HasColumnName("RnRID");

                entity.Property(e => e.SpaceportId).HasColumnName("SpaceportID");

                entity.Property(e => e.TypeRbid).HasColumnName("TypeRBID");

                entity.Property(e => e.TypeRnid).HasColumnName("TypeRNID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VSpaceLaunchSetGetRn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaceLaunch#Set#GetRN");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RnRid).HasColumnName("RnRID");

                entity.Property(e => e.SpaceportId).HasColumnName("SpaceportID");

                entity.Property(e => e.TypeRnid).HasColumnName("TypeRNID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VSpaceLaunchSetLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaceLaunch#Set_Light");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.ClassRnCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClassRN_Code");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ObRid).HasColumnName("ObRID");

                entity.Property(e => e.ObRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("ObRID_Code");

                entity.Property(e => e.ObRidName)
                    .HasMaxLength(260)
                    .HasColumnName("ObRID_Name");

                entity.Property(e => e.ObStateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("ObStateID_Code");

                entity.Property(e => e.ObTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("ObTypeID_Code");

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.RbRid).HasColumnName("RbRID");

                entity.Property(e => e.RbRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("RbRID_Code");

                entity.Property(e => e.RbRidName)
                    .HasMaxLength(260)
                    .HasColumnName("RbRID_Name");

                entity.Property(e => e.RbStateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("RbStateID_Code");

                entity.Property(e => e.RbTypeId).HasColumnName("RbTypeID");

                entity.Property(e => e.RbTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("RbTypeID_Code");

                entity.Property(e => e.RbTypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("RbTypeID_Name");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RnRid).HasColumnName("RnRID");

                entity.Property(e => e.RnRidCode)
                    .HasMaxLength(50)
                    .HasColumnName("RnRID_Code");

                entity.Property(e => e.RnRidName)
                    .HasMaxLength(260)
                    .HasColumnName("RnRID_Name");

                entity.Property(e => e.RnStateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("RnStateID_Code");

                entity.Property(e => e.RnTypeId).HasColumnName("RnTypeID");

                entity.Property(e => e.RnTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("RnTypeID_Code");

                entity.Property(e => e.RnTypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("RnTypeID_Name");

                entity.Property(e => e.SlRid).HasColumnName("SlRID");

                entity.Property(e => e.SlRidCode)
                    .HasMaxLength(260)
                    .HasColumnName("SlRID_Code");

                entity.Property(e => e.SlRidName)
                    .HasMaxLength(260)
                    .HasColumnName("SlRID_Name");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VSpaceLaunchSetSpec>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaceLaunch#Set#Spec");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.KaRid).HasColumnName("KaRID");

                entity.Property(e => e.KkCode)
                    .HasMaxLength(50)
                    .HasColumnName("KK_Code");

                entity.Property(e => e.KkName)
                    .HasMaxLength(1000)
                    .HasColumnName("KK_Name");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PlanSas)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PlanSAS");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSystemCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystem_Code");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");
            });

            modelBuilder.Entity<VSpaceLaunchSetSpecVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaceLaunch#Set#Spec#Version");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KaRid).HasColumnName("KaRID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VSpacePolicyObjective>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpacePolicy#Objective");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VSpacePolicyObjectiveDirection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpacePolicy#Objective#Direction");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Numb).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VSpacePolicyObjectiveObjective>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpacePolicy#Objective#Objective");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VSpaceSystemSpaceSystem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaceSystem#SpaceSystem");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.CnidCode)
                    .HasMaxLength(260)
                    .HasColumnName("CNID_Code");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSpacecraftSpacecraft>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpacecraft#Spacecraft");

                entity.Property(e => e.BoosterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Booster_Code");

                entity.Property(e => e.BoosterId).HasColumnName("BoosterID");

                entity.Property(e => e.BoosterIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("BoosterID_Code");

                entity.Property(e => e.CategoryCode).HasMaxLength(260);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(260);

                entity.Property(e => e.ClassRnCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClassRN_Code");

                entity.Property(e => e.FactDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.FactDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.FlightModel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IsBudget).HasColumnName("isBudget");

                entity.Property(e => e.IsFlightModel).HasColumnName("isFlightModel");

                entity.Property(e => e.Karid).HasColumnName("KARID");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.KkidDocNum).HasColumnName("KKID_DocNum");

                entity.Property(e => e.KkidName)
                    .HasMaxLength(1000)
                    .HasColumnName("KKID_Name");

                entity.Property(e => e.NCountEvent).HasColumnName("nCountEvent");

                entity.Property(e => e.Name)
                    .HasMaxLength(269)
                    .HasColumnName("NAME");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ObtekatelCode)
                    .HasMaxLength(50)
                    .HasColumnName("Obtekatel_Code");

                entity.Property(e => e.ObtekatelId).HasColumnName("ObtekatelID");

                entity.Property(e => e.ObtekatelIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("ObtekatelID_Code");

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo1).HasColumnType("date");

                entity.Property(e => e.RbTypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("rbTypeID_Name");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RocketCode)
                    .HasMaxLength(50)
                    .HasColumnName("Rocket_Code");

                entity.Property(e => e.RocketId).HasColumnName("RocketID");

                entity.Property(e => e.RocketIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RocketID_Code");

                entity.Property(e => e.RocketIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("RocketID_Name");

                entity.Property(e => e.SpaceLaunchCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunch_Code");

                entity.Property(e => e.SpaceLaunchId).HasColumnName("SpaceLaunchID");

                entity.Property(e => e.SpaceLaunchIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunchID_Code");

                entity.Property(e => e.SpaceLaunchSetId).HasColumnName("SpaceLaunchSetID");

                entity.Property(e => e.SpaceLaunchSetIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceLaunchSetID_Code");

                entity.Property(e => e.SpaceLaunchSetIdName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceLaunchSetID_Name");

                entity.Property(e => e.SpaceSystemCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystem_Code");

                entity.Property(e => e.SpaceSystemId).HasColumnName("SpaceSystemID");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.SpacecraftCode)
                    .HasMaxLength(311)
                    .HasColumnName("Spacecraft_Code");

                entity.Property(e => e.SpacecraftDescription)
                    .HasMaxLength(2000)
                    .HasColumnName("Spacecraft_Description");

                entity.Property(e => e.SpacecraftId).HasColumnName("SpacecraftID");

                entity.Property(e => e.SpacecraftIdCode)
                    .HasMaxLength(311)
                    .HasColumnName("SpacecraftID_Code");

                entity.Property(e => e.SpacecraftShortName)
                    .HasMaxLength(260)
                    .HasColumnName("Spacecraft_ShortName");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("State_Code");

                entity.Property(e => e.StateName)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.Property(e => e.StorageExpirationDateOb)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("StorageExpirationDateOB");

                entity.Property(e => e.StorageExpirationDateRb)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("StorageExpirationDateRB");

                entity.Property(e => e.StorageExpirationDateRn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("StorageExpirationDateRN");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VSpacecraftSpacecraftCalc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpacecraft#SpacecraftCalc");

                entity.Property(e => e.BoosterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Booster_Code");

                entity.Property(e => e.BoosterId).HasColumnName("BoosterID");

                entity.Property(e => e.BoosterIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("BoosterID_Code");

                entity.Property(e => e.CategoryCode).HasMaxLength(260);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(260);

                entity.Property(e => e.FactDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.FlightModel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IsFlightModel).HasColumnName("isFlightModel");

                entity.Property(e => e.Karid).HasColumnName("KARID");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidDocNum).HasColumnName("KKID_DocNum");

                entity.Property(e => e.NEx).HasColumnName("nEx");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ObtekatelCode)
                    .HasMaxLength(50)
                    .HasColumnName("Obtekatel_Code");

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RocketCode)
                    .HasMaxLength(1000)
                    .HasColumnName("Rocket_Code");

                entity.Property(e => e.RocketId).HasColumnName("RocketID");

                entity.Property(e => e.RocketIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RocketID_Code");

                entity.Property(e => e.SpaceLaunchCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunch_Code");

                entity.Property(e => e.SpaceLaunchId).HasColumnName("SpaceLaunchID");

                entity.Property(e => e.SpaceLaunchIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunchID_Code");

                entity.Property(e => e.SpaceLaunchSetIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceLaunchSetID_Code");

                entity.Property(e => e.SpaceSystemCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystem_Code");

                entity.Property(e => e.SpaceSystemId).HasColumnName("SpaceSystemID");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.SpacecraftCode)
                    .HasMaxLength(311)
                    .HasColumnName("Spacecraft_Code");

                entity.Property(e => e.SpacecraftId).HasColumnName("SpacecraftID");

                entity.Property(e => e.SpacecraftIdCode)
                    .HasMaxLength(311)
                    .HasColumnName("SpacecraftID_Code");

                entity.Property(e => e.StateName)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VSpacecraftSpacecraftCalcPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpacecraft#SpacecraftCalcPlan");

                entity.Property(e => e.BoosterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Booster_Code");

                entity.Property(e => e.BoosterId).HasColumnName("BoosterID");

                entity.Property(e => e.BoosterIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("BoosterID_Code");

                entity.Property(e => e.CategoryCode).HasMaxLength(260);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(260);

                entity.Property(e => e.FactDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.FlightModel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IsFlightModel).HasColumnName("isFlightModel");

                entity.Property(e => e.Karid).HasColumnName("KARID");

                entity.Property(e => e.NEx).HasColumnName("nEx");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ObtekatelCode)
                    .HasMaxLength(50)
                    .HasColumnName("Obtekatel_Code");

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RocketCode)
                    .HasMaxLength(1000)
                    .HasColumnName("Rocket_Code");

                entity.Property(e => e.RocketId).HasColumnName("RocketID");

                entity.Property(e => e.RocketIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RocketID_Code");

                entity.Property(e => e.SpaceLaunchCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunch_Code");

                entity.Property(e => e.SpaceLaunchId).HasColumnName("SpaceLaunchID");

                entity.Property(e => e.SpaceLaunchIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunchID_Code");

                entity.Property(e => e.SpaceLaunchSetIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceLaunchSetID_Code");

                entity.Property(e => e.SpaceSystemCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystem_Code");

                entity.Property(e => e.SpaceSystemId).HasColumnName("SpaceSystemID");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.SpacecraftCode)
                    .HasMaxLength(311)
                    .HasColumnName("Spacecraft_Code");

                entity.Property(e => e.SpacecraftId).HasColumnName("SpacecraftID");

                entity.Property(e => e.SpacecraftIdCode)
                    .HasMaxLength(311)
                    .HasColumnName("SpacecraftID_Code");

                entity.Property(e => e.StateName)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VSpacecraftSpacecraftLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpacecraft#Spacecraft_Light");

                entity.Property(e => e.BoosterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Booster_Code");

                entity.Property(e => e.BoosterId).HasColumnName("BoosterID");

                entity.Property(e => e.BoosterIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("BoosterID_Code");

                entity.Property(e => e.CategoryCode).HasMaxLength(260);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(260);

                entity.Property(e => e.ClassRnCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClassRN_Code");

                entity.Property(e => e.FactDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.FactDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.FlightModel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IsBudget).HasColumnName("isBudget");

                entity.Property(e => e.IsFlightModel).HasColumnName("isFlightModel");

                entity.Property(e => e.Karid).HasColumnName("KARID");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.KkidDocNum).HasColumnName("KKID_DocNum");

                entity.Property(e => e.KkidName)
                    .HasMaxLength(1000)
                    .HasColumnName("KKID_Name");

                entity.Property(e => e.NCountEvent).HasColumnName("nCountEvent");

                entity.Property(e => e.Name)
                    .HasMaxLength(270)
                    .HasColumnName("NAME");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ObtekatelCode)
                    .HasMaxLength(50)
                    .HasColumnName("Obtekatel_Code");

                entity.Property(e => e.ObtekatelId).HasColumnName("ObtekatelID");

                entity.Property(e => e.ObtekatelIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("ObtekatelID_Code");

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo1).HasColumnType("date");

                entity.Property(e => e.RbTypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("rbTypeID_Name");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RocketCode)
                    .HasMaxLength(50)
                    .HasColumnName("Rocket_Code");

                entity.Property(e => e.RocketId).HasColumnName("RocketID");

                entity.Property(e => e.RocketIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RocketID_Code");

                entity.Property(e => e.RocketIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("RocketID_Name");

                entity.Property(e => e.SpaceLaunchCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunch_Code");

                entity.Property(e => e.SpaceLaunchId).HasColumnName("SpaceLaunchID");

                entity.Property(e => e.SpaceLaunchIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunchID_Code");

                entity.Property(e => e.SpaceLaunchSetId).HasColumnName("SpaceLaunchSetID");

                entity.Property(e => e.SpaceLaunchSetIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceLaunchSetID_Code");

                entity.Property(e => e.SpaceLaunchSetIdName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceLaunchSetID_Name");

                entity.Property(e => e.SpaceSystemCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystem_Code");

                entity.Property(e => e.SpaceSystemId).HasColumnName("SpaceSystemID");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.SpacecraftCode)
                    .HasMaxLength(311)
                    .HasColumnName("Spacecraft_Code");

                entity.Property(e => e.SpacecraftDescription)
                    .HasMaxLength(2000)
                    .HasColumnName("Spacecraft_Description");

                entity.Property(e => e.SpacecraftId).HasColumnName("SpacecraftID");

                entity.Property(e => e.SpacecraftIdCode)
                    .HasMaxLength(311)
                    .HasColumnName("SpacecraftID_Code");

                entity.Property(e => e.SpacecraftShortName)
                    .HasMaxLength(260)
                    .HasColumnName("Spacecraft_ShortName");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("State_Code");

                entity.Property(e => e.StateName)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VSpacecraftSpacecraftSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpacecraft#SpacecraftSchedule");

                entity.Property(e => e.BoosterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Booster_Code");

                entity.Property(e => e.BoosterId).HasColumnName("BoosterID");

                entity.Property(e => e.BoosterIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("BoosterID_Code");

                entity.Property(e => e.BoosterTypeName)
                    .HasMaxLength(1000)
                    .HasColumnName("BoosterType_Name");

                entity.Property(e => e.CategoryCode).HasMaxLength(260);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(260);

                entity.Property(e => e.ClassRnCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClassRN_Code");

                entity.Property(e => e.FactDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.FactDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.FlightModel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IsBudget).HasColumnName("isBudget");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.MinimumDate).HasColumnType("smalldatetime");

                entity.Property(e => e.NCountEvent).HasColumnName("nCountEvent");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ObtekatelCode)
                    .HasMaxLength(50)
                    .HasColumnName("Obtekatel_Code");

                entity.Property(e => e.ObtekatelId).HasColumnName("ObtekatelID");

                entity.Property(e => e.ObtekatelIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("ObtekatelID_Code");

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.PlanDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RocketCode)
                    .HasMaxLength(50)
                    .HasColumnName("Rocket_Code");

                entity.Property(e => e.RocketId).HasColumnName("RocketID");

                entity.Property(e => e.RocketIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RocketID_Code");

                entity.Property(e => e.RocketTypeName)
                    .HasMaxLength(1000)
                    .HasColumnName("RocketType_Name");

                entity.Property(e => e.SpaceLaunchCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunch_Code");

                entity.Property(e => e.SpaceLaunchId).HasColumnName("SpaceLaunchID");

                entity.Property(e => e.SpaceLaunchIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunchID_Code");

                entity.Property(e => e.SpaceLaunchSetId).HasColumnName("SpaceLaunchSetID");

                entity.Property(e => e.SpaceLaunchSetIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceLaunchSetID_Code");

                entity.Property(e => e.SpaceLaunchSetIdName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceLaunchSetID_Name");

                entity.Property(e => e.SpaceLaunchSetNote).HasColumnName("SpaceLaunchSet_Note");

                entity.Property(e => e.SpaceSystemId).HasColumnName("SpaceSystemID");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.SpacecraftCode)
                    .HasMaxLength(311)
                    .HasColumnName("Spacecraft_Code");

                entity.Property(e => e.SpacecraftDescription)
                    .HasMaxLength(2000)
                    .HasColumnName("Spacecraft_Description");

                entity.Property(e => e.SpacecraftId).HasColumnName("SpacecraftID");

                entity.Property(e => e.SpacecraftIdCode)
                    .HasMaxLength(311)
                    .HasColumnName("SpacecraftID_Code");

                entity.Property(e => e.SpacecraftShortName)
                    .HasMaxLength(260)
                    .HasColumnName("Spacecraft_ShortName");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("State_Code");

                entity.Property(e => e.StateName)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.Property(e => e.StorageExpirationDateOb)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("StorageExpirationDateOB");

                entity.Property(e => e.StorageExpirationDateRb)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("StorageExpirationDateRB");

                entity.Property(e => e.StorageExpirationDateRn)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("StorageExpirationDateRN");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.Y2015).HasColumnName("y2015");

                entity.Property(e => e.Y2016).HasColumnName("y2016");

                entity.Property(e => e.Y2017).HasColumnName("y2017");

                entity.Property(e => e.Y2018).HasColumnName("y2018");

                entity.Property(e => e.Y2019).HasColumnName("y2019");

                entity.Property(e => e.Y2020).HasColumnName("y2020");

                entity.Property(e => e.Y2021).HasColumnName("y2021");

                entity.Property(e => e.Y2022).HasColumnName("y2022");

                entity.Property(e => e.Y2023).HasColumnName("y2023");

                entity.Property(e => e.Y2024).HasColumnName("y2024");

                entity.Property(e => e.Y2025).HasColumnName("y2025");

                entity.Property(e => e.Y2026).HasColumnName("y2026");

                entity.Property(e => e.Y2027).HasColumnName("y2027");

                entity.Property(e => e.Y2028).HasColumnName("y2028");

                entity.Property(e => e.Y2029).HasColumnName("y2029");

                entity.Property(e => e.Y2030).HasColumnName("y2030");

                entity.Property(e => e.Y2031).HasColumnName("y2031");

                entity.Property(e => e.Y2032).HasColumnName("y2032");

                entity.Property(e => e.Y2033).HasColumnName("y2033");

                entity.Property(e => e.Y2034).HasColumnName("y2034");

                entity.Property(e => e.Y2035).HasColumnName("y2035");

                entity.Property(e => e.Y2036).HasColumnName("y2036");

                entity.Property(e => e.Y2037).HasColumnName("y2037");

                entity.Property(e => e.Y2038).HasColumnName("y2038");

                entity.Property(e => e.Y2039).HasColumnName("y2039");

                entity.Property(e => e.Y2040).HasColumnName("y2040");
            });

            modelBuilder.Entity<VSpacecraftSpacecraftScheduleCalc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpacecraft#SpacecraftScheduleCalc");

                entity.Property(e => e.BoosterCode)
                    .HasMaxLength(50)
                    .HasColumnName("Booster_Code");

                entity.Property(e => e.BoosterId).HasColumnName("BoosterID");

                entity.Property(e => e.BoosterIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("BoosterID_Code");

                entity.Property(e => e.CategoryCode).HasMaxLength(260);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(260);

                entity.Property(e => e.FactDateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.FlightModel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IsBudget)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("isBudget");

                entity.Property(e => e.IsWorldClass).HasColumnName("isWorldClass");

                entity.Property(e => e.NEx).HasColumnName("nEx");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ObtekatelCode)
                    .HasMaxLength(50)
                    .HasColumnName("Obtekatel_Code");

                entity.Property(e => e.PlanDateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RocketCode)
                    .HasMaxLength(1000)
                    .HasColumnName("Rocket_Code");

                entity.Property(e => e.RocketId).HasColumnName("RocketID");

                entity.Property(e => e.RocketIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RocketID_Code");

                entity.Property(e => e.SpaceLaunchCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunch_Code");

                entity.Property(e => e.SpaceLaunchId).HasColumnName("SpaceLaunchID");

                entity.Property(e => e.SpaceLaunchIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceLaunchID_Code");

                entity.Property(e => e.SpaceLaunchSetIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceLaunchSetID_Code");

                entity.Property(e => e.SpaceSystemCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystem_Code");

                entity.Property(e => e.SpaceSystemId).HasColumnName("SpaceSystemID");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.SpacecraftCode)
                    .HasMaxLength(311)
                    .HasColumnName("Spacecraft_Code");

                entity.Property(e => e.SpacecraftId).HasColumnName("SpacecraftID");

                entity.Property(e => e.SpacecraftIdCode)
                    .HasMaxLength(311)
                    .HasColumnName("SpacecraftID_Code");

                entity.Property(e => e.StateName)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VSpaceportCoordinate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaceport#Coordinate");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Lantitude).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Longtitude).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSpaseLaunchSetGetUnallocatedKa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSpaseLaunch#Set#GetUnallocatedKA");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("CategoryID_Code");

                entity.Property(e => e.CategoryIdName)
                    .HasMaxLength(260)
                    .HasColumnName("CategoryID_Name");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.KkidName)
                    .HasMaxLength(260)
                    .HasColumnName("KKID_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.SpaceSetName)
                    .HasMaxLength(250)
                    .HasColumnName("SpaceSet_Name");

                entity.Property(e => e.SpaceSystemId).HasColumnName("SpaceSystemID");

                entity.Property(e => e.SpaceSystemIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystemID_Code");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.TypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VStageStage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStage#Stage");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.DictionaryWorkId).HasColumnName("DictionaryWorkID");

                entity.Property(e => e.Gostid).HasColumnName("GOSTID");

                entity.Property(e => e.GostidCode)
                    .HasMaxLength(50)
                    .HasColumnName("GOSTID_Code");

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.KindIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("KindID_Code");

                entity.Property(e => e.LastDateRiskCalculate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.R12).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R13).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R21).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R23).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R31).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R32).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RiskValueR)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R");

                entity.Property(e => e.RiskValueR1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R1");

                entity.Property(e => e.RiskValueR2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R2");

                entity.Property(e => e.RiskValueR3)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R3");

                entity.Property(e => e.StagePercent).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StageTypeId).HasColumnName("StageTypeID");

                entity.Property(e => e.StageTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("StageTypeID_Code");

                entity.Property(e => e.StageTypeIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("StageTypeID_Name");

                entity.Property(e => e.StageValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.WorkCategoryId).HasColumnName("WorkCategoryID");

                entity.Property(e => e.WorkCategoryIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkCategoryID_Code");

                entity.Property(e => e.WorkCodeCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkCode_Code");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkTypeCode)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VStructureAgentGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#AgentGroup");

                entity.Property(e => e.AgentGroupId).HasColumnName("AgentGroupID");

                entity.Property(e => e.AgentGroupIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("AgentGroupID_Code");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VStructureElement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#Element");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");
            });

            modelBuilder.Entity<VStructureElementEfficiency>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#Element#Efficiency");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StructurePath).HasColumnName("Structure_path");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeIdCode).HasColumnName("WorkCodeID_Code");
            });

            modelBuilder.Entity<VStructureElementLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#Element#Light");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");
            });

            modelBuilder.Entity<VStructureParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#Param");

                entity.Property(e => e.CalcDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsActual).HasColumnName("isActual");

                entity.Property(e => e.IsBasic).HasColumnName("isBasic");

                entity.Property(e => e.IsManual).HasColumnName("isManual");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ParamID_Code");

                entity.Property(e => e.ParamIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("ParamID_Name");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PersonName)
                    .HasMaxLength(2000)
                    .HasColumnName("Person_Name");

                entity.Property(e => e.PersonUserName)
                    .HasMaxLength(260)
                    .HasColumnName("Person_UserName");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VStructureRelation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#Relation");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("TypeID_Code");
            });

            modelBuilder.Entity<VStructureStructure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#Structure");

                entity.Property(e => e.CipCode)
                    .HasMaxLength(2000)
                    .HasColumnName("CIP_Code");

                entity.Property(e => e.Code).HasMaxLength(260);

                entity.Property(e => e.DirectionCode)
                    .HasMaxLength(2000)
                    .HasColumnName("Direction_Code");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.LastDateRiskCalculate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R12).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R13).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R21).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R23).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R31).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.R32).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RiskValueR)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R");

                entity.Property(e => e.RiskValueR1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R1");

                entity.Property(e => e.RiskValueR2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R2");

                entity.Property(e => e.RiskValueR3)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Risk_Value_R3");

                entity.Property(e => e.SectionIdCode)
                    .HasMaxLength(464)
                    .HasColumnName("SectionID_Code");

                entity.Property(e => e.SpacePolicyObjectiveNum).HasColumnName("SpacePolicyObjective_Num");

                entity.Property(e => e.TypeIdCode).HasColumnName("TypeID_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VStructureStructureEfficiency>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#Structure#Efficiency");

                entity.Property(e => e.CalcDate).HasColumnType("date");

                entity.Property(e => e.CipCode)
                    .HasMaxLength(2000)
                    .HasColumnName("CIP_Code");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DirectionCode)
                    .HasMaxLength(2000)
                    .HasColumnName("Direction_Code");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkTypeCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");

                entity.Property(e => e.Y2016)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("y2016");

                entity.Property(e => e.Y2017)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("y2017");

                entity.Property(e => e.Y2018)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("y2018");

                entity.Property(e => e.Y2019)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("y2019");

                entity.Property(e => e.Y2020)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("y2020");

                entity.Property(e => e.Y2021)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("y2021");

                entity.Property(e => e.Y2022)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("y2022");

                entity.Property(e => e.Y2023)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("y2023");

                entity.Property(e => e.Y2024)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("y2024");

                entity.Property(e => e.Y2025)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("y2025");
            });

            modelBuilder.Entity<VStructureStructureGetWorkGanttResourceTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#Structure#GetWorkGanttResource#Temp");

                entity.Property(e => e.Color).HasMaxLength(10);

                entity.Property(e => e.KindId).HasColumnName("KindID");

                entity.Property(e => e.KindIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("KindID_Code");

                entity.Property(e => e.MainRid).HasColumnName("MainRID");

                entity.Property(e => e.NType).HasColumnName("nType");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StageSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.StageSumEdit).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Summ).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.SummEdit).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.UserName).HasMaxLength(128);
            });

            modelBuilder.Entity<VStructureStructureGetWorkGanttSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#Structure#GetWorkGantt#Session");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateBegin).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(260);

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.OwnerUserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PersonIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkTypeCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("WorkType_Code");
            });

            modelBuilder.Entity<VStructureStructureLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#Structure#Light");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VStructureTargetIndicator>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#TargetIndicator");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IndicatorId).HasColumnName("IndicatorID");

                entity.Property(e => e.IndicatorIdCode)
                    .HasMaxLength(1000)
                    .HasColumnName("IndicatorID_Code");

                entity.Property(e => e.IsCalcEfficiency).HasColumnName("isCalcEfficiency");

                entity.Property(e => e.Koeff).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(250);
            });

            modelBuilder.Entity<VStructureWorkDirection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStructure#WorkDirection");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSysAgentType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Agent#Type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysColumnPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Column#Permission");

                entity.Property(e => e.AttFieldName).HasMaxLength(50);

                entity.Property(e => e.AttName).HasMaxLength(160);

                entity.Property(e => e.AttType).HasMaxLength(20);

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<VSysDictionaryWorkFinDirection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Dictionary#Work#FinDirection");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(28)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysDictionaryWorkState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Dictionary#Work#State");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(56)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysEventKind>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#EventKind");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Level0)
                    .HasMaxLength(50)
                    .HasColumnName("level0");

                entity.Property(e => e.NLevel).HasColumnName("nLevel");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSysEventMessageType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#EventMessage#Type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(29)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysFinanceKind>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#FinanceKind");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Level1)
                    .HasMaxLength(50)
                    .HasColumnName("level1");

                entity.Property(e => e.NLevel).HasColumnName("nLevel");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSysKaState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#KA#State");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(28)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysLinkType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#LinkType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysMmWorkGroupPersonRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#MM#Work#Group#Person#Role");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(38)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("numeric(2, 1)");
            });

            modelBuilder.Entity<VSysMmWorkPersonParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#MM#Work#Person#Param");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("numeric(2, 1)");
            });

            modelBuilder.Entity<VSysMmWorkRapidKoef>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#MM#Work#RapidKoef");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("numeric(3, 2)");
            });

            modelBuilder.Entity<VSysParamDataType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Param#DataType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysPriorityCriterionAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#PriorityCriterion#Attachment");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysPriorityCriterionRankValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#PriorityCriterion#Rank#Value");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.InvValue)
                    .HasColumnType("numeric(3, 2)")
                    .HasColumnName("invValue");

                entity.Property(e => e.NValue)
                    .HasColumnType("numeric(3, 2)")
                    .HasColumnName("nValue");

                entity.Property(e => e.SValue)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sValue");
            });

            modelBuilder.Entity<VSysPriorityRankValueDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#PriorityRankValue#Description");

                entity.Property(e => e.NValue)
                    .HasColumnType("numeric(3, 2)")
                    .HasColumnName("nValue");

                entity.Property(e => e.SValue)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("sValue");
            });

            modelBuilder.Entity<VSysProjectType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Project#Type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysRelationType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Relation#Type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(34)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysReportParamsLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Report#Params#Link");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(28)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysResultKind>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#ResultKind");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Level1)
                    .HasMaxLength(50)
                    .HasColumnName("level1");

                entity.Property(e => e.NLevel).HasColumnName("nLevel");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSysRiskValueDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#RiskValue#Description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("numeric(3, 2)");
            });

            modelBuilder.Entity<VSysRnrbobState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#RNRBOB#State");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(28)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysSpacecraftState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Spacecraft#State");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysSystemIssuePriority>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#System#Issue#Priority");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysSystemIssueState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#System#Issue#State");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysSystemIssueType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#System#Issue#Type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysSystemSettingType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#SystemSetting#Type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysTargetIndicatorElementType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#TargetIndicator#ElementType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysTargetIndicatorTrendType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#TargetIndicator#TrendType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysTaskElementChangeType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#TaskElement#ChangeType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysTaskElementState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#TaskElement#State");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysTaskHistoryActionType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#TaskHistory#ActionType");

                entity.Property(e => e.Name)
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysTaskResultValueState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Task#ResultValue#State");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysTaskState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Task#State");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysTaskStepState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Task#Step#State");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysTechnicTypeClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#TechnicType#Class");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysUserArpParamsDataType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#UserARP#Params#DataType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysUserGraphType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#UserGraph#Type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysVersionState>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Version#State");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(22)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysWorkAgentType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Work#AgentType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysWorkParamCalculateType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Work#Param#CalculateType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(21)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysWorkType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Work#Type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSysYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSys#Year");

                entity.Property(e => e.NYear).HasColumnName("nYear");
            });

            modelBuilder.Entity<VSystemAdminUpdateInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Admin#Update#Info");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatePackageName).HasMaxLength(255);

                entity.Property(e => e.UpdateVersion).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<VSystemAdminUpdateInfoSpec>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Admin#Update#Info#Spec");

                entity.Property(e => e.DateBegin).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSystemAllEntrye>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#AllEntryes");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(47)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSystemAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Audit");

                entity.Property(e => e.ChangeTime).HasColumnType("datetime");

                entity.Property(e => e.Ctype)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CType");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.UserRid).HasColumnName("UserRID");
            });

            modelBuilder.Entity<VSystemAuditLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#AuditLog");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.CallParams).HasMaxLength(2000);

                entity.Property(e => e.CallProcedure).HasMaxLength(260);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.UserName).HasMaxLength(2073);
            });

            modelBuilder.Entity<VSystemBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Backup");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSystemCurrentUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#CurrentUser");

                entity.Property(e => e.Description).HasMaxLength(260);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SqlloginName)
                    .HasMaxLength(128)
                    .HasColumnName("SQLLoginName");

                entity.Property(e => e.SqluserId).HasColumnName("SQLUserID");

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");
            });

            modelBuilder.Entity<VSystemErrorLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#ErrorLog");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ErrorDescription).HasMaxLength(2000);

                entity.Property(e => e.ErrorSystemDescription).HasMaxLength(2000);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.ProcName).HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(260);
            });

            modelBuilder.Entity<VSystemGetNewId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#GetNewID");

                entity.Property(e => e.NewId).HasColumnName("NEW_ID");
            });

            modelBuilder.Entity<VSystemIssue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Issue");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DateNotifyExecutor).HasColumnType("datetime");

                entity.Property(e => e.ErrorId).HasColumnName("ErrorID");

                entity.Property(e => e.ErrorName)
                    .HasMaxLength(2000)
                    .HasColumnName("Error_Name");

                entity.Property(e => e.Executor).HasMaxLength(250);

                entity.Property(e => e.ExternalNumber).HasMaxLength(50);

                entity.Property(e => e.FactDateAccept).HasColumnType("datetime");

                entity.Property(e => e.FactDateExecution).HasColumnType("datetime");

                entity.Property(e => e.Issue).IsRequired();

                entity.Property(e => e.LinkDocs).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.PersonIdDepartment)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PersonID_Department");

                entity.Property(e => e.PersonIdPost)
                    .HasMaxLength(260)
                    .HasColumnName("PersonID_Post");

                entity.Property(e => e.PlannedPeriod).HasColumnType("datetime");

                entity.Property(e => e.PriorityId).HasColumnName("PriorityID");

                entity.Property(e => e.PriorityIdCode)
                    .IsRequired()
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("PriorityID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Screenshot).HasColumnType("image");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionIdName)
                    .HasMaxLength(260)
                    .HasColumnName("SectionID_Name");

                entity.Property(e => e.StateDate).HasColumnType("datetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(31)
                    .IsUnicode(false)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VSystemIssueAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Issue#Agent");

                entity.Property(e => e.AddName).HasMaxLength(2000);

                entity.Property(e => e.Address).HasMaxLength(2000);

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Cpp)
                    .HasMaxLength(50)
                    .HasColumnName("CPP");

                entity.Property(e => e.DateR).HasColumnType("smalldatetime");

                entity.Property(e => e.FirstName).HasMaxLength(260);

                entity.Property(e => e.Inn)
                    .HasMaxLength(50)
                    .HasColumnName("INN");

                entity.Property(e => e.LastName).HasMaxLength(260);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Ogrn)
                    .HasMaxLength(50)
                    .HasColumnName("OGRN");

                entity.Property(e => e.Okpo)
                    .HasMaxLength(50)
                    .HasColumnName("OKPO");

                entity.Property(e => e.Patronymic).HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSystemIssueAgentPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Issue#AgentPerson");

                entity.Property(e => e.AcademicDegree).HasMaxLength(250);

                entity.Property(e => e.AcademicTitle).HasMaxLength(250);

                entity.Property(e => e.AddEducation).HasMaxLength(2000);

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Education).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.ProffKoef).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.TabNum).HasMaxLength(50);

                entity.Property(e => e.WorkExp).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<VSystemIssueCatalog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Issue#Catalog");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSystemIssueDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Issue#Department");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);
            });

            modelBuilder.Entity<VSystemIssueDictionary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Issue#Dictionary");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSystemIssueHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Issue#History");

                entity.Property(e => e.AgentIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("AgentID_Code");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateDate).HasColumnType("datetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VSystemIssuePost>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Issue#Post");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);
            });

            modelBuilder.Entity<VSystemLicense>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#License");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.Property(e => e.OrganizationIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("OrganizationID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VSystemPermissionColumn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Permission#Column");

                entity.Property(e => e.ColumnArea).HasMaxLength(100);

                entity.Property(e => e.ColumnId).HasColumnName("ColumnID");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VSystemProcedure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Procedure");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSystemProcedureParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#ProcedureParameters");

                entity.Property(e => e.CharacterMaximumLength).HasColumnName("CHARACTER_MAXIMUM_LENGTH");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("DATA_TYPE");

                entity.Property(e => e.NumericPrecision).HasColumnName("NUMERIC_PRECISION");

                entity.Property(e => e.NumericScale).HasColumnName("NUMERIC_SCALE");

                entity.Property(e => e.ParameterMode)
                    .HasMaxLength(10)
                    .HasColumnName("PARAMETER_MODE");

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(128)
                    .HasColumnName("PARAMETER_NAME");

                entity.Property(e => e.SpecificName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("SPECIFIC_NAME");
            });

            modelBuilder.Entity<VSystemRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Role");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSystemRolePermissionAction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Role#Permission#Action");

                entity.Property(e => e.ActionArea).HasMaxLength(100);

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ActionName).HasMaxLength(4000);

                entity.Property(e => e.AttName).HasMaxLength(160);

                entity.Property(e => e.Idx).HasColumnName("IDX");

                entity.Property(e => e.IdxGr).HasColumnName("IDX_GR");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(260);

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<VSystemRolePermissionActionCatalog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Role#Permission#Action#Catalog");

                entity.Property(e => e.ActionArea).HasMaxLength(100);

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ActionName).HasMaxLength(4000);

                entity.Property(e => e.AttName).HasMaxLength(160);

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.CatalogName).HasMaxLength(260);

                entity.Property(e => e.Idx).HasColumnName("idx");

                entity.Property(e => e.IdxGr).HasColumnName("idx_gr");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(260);

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<VSystemRolePermissionActionHelper>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Role#Permission#Action#Helper");

                entity.Property(e => e.AttCaption).HasMaxLength(4000);

                entity.Property(e => e.Idx).HasColumnName("IDX");

                entity.Property(e => e.IdxGr).HasColumnName("IDX_GR");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSystemRolePermissionColumn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Role#Permission#Column");

                entity.Property(e => e.AttCaption).HasMaxLength(100);

                entity.Property(e => e.AttFieldName).HasMaxLength(50);

                entity.Property(e => e.AttName).HasMaxLength(160);

                entity.Property(e => e.AttType).HasMaxLength(20);

                entity.Property(e => e.ColumnArea).HasMaxLength(100);

                entity.Property(e => e.ColumnId).HasColumnName("ColumnID");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(260);

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<VSystemRolePermissionEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Role#Permission#Entry");

                entity.Property(e => e.ClassName).HasMaxLength(250);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.EntryName).HasMaxLength(260);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(260);

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<VSystemRolePermissionUserReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Role#Permission#UserReport");

                entity.Property(e => e.IsBlock).HasColumnName("isBlock");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(260)
                    .HasColumnName("Role_Name");

                entity.Property(e => e.SqluserId).HasColumnName("SQLUserID");

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");
            });

            modelBuilder.Entity<VSystemRolePremissionPack>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Role#Premission#Pack");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.XmlPack).HasColumnName("XML_PACK");
            });

            modelBuilder.Entity<VSystemRoleUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Role#User");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.IsBlock).HasColumnName("isBlock");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RoleID_Code");

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("UserID_Code");

                entity.Property(e => e.UserIdName)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("UserID_Name");
            });

            modelBuilder.Entity<VSystemSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Session");

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RoleIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RoleID_Code");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(2000);
            });

            modelBuilder.Entity<VSystemSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Setting");

                entity.Property(e => e.AttCaption).HasMaxLength(100);

                entity.Property(e => e.AttName).HasMaxLength(160);

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.IsGlobal).HasColumnName("isGlobal");

                entity.Property(e => e.LinksectionCode)
                    .HasMaxLength(260)
                    .HasColumnName("LINKSECTION_CODE");

                entity.Property(e => e.LinksectionSysCode)
                    .HasMaxLength(50)
                    .HasColumnName("LINKSECTION_SYS_CODE");

                entity.Property(e => e.NType).HasColumnName("nType");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RoleIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RoleID_Code");

                entity.Property(e => e.SType)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("sType");

                entity.Property(e => e.SettingValue).HasMaxLength(500);

                entity.Property(e => e.UserIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("UserID_Code");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<VSystemSqluser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#SQLUser");

                entity.Property(e => e.SqlloginName)
                    .HasMaxLength(128)
                    .HasColumnName("SQLLoginName");

                entity.Property(e => e.SqluserId).HasColumnName("SQLUserID");

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("SQLUserName");
            });

            modelBuilder.Entity<VSystemUpdateApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#Update#App");

                entity.Property(e => e.FileData)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileVersion).HasMaxLength(20);

                entity.Property(e => e.HashSum)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RelPath)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VSystemUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#User");

                entity.Property(e => e.BlockDate).HasColumnType("date");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(260);

                entity.Property(e => e.IsBlock).HasColumnName("isBlock");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SqlloginName)
                    .HasMaxLength(128)
                    .HasColumnName("SQLLoginName");

                entity.Property(e => e.SqluserId).HasColumnName("SQLUserID");

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");
            });

            modelBuilder.Entity<VSystemUserOrganization>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#User#Organization");

                entity.Property(e => e.OrganizationId).HasColumnName("OrganizationID");

                entity.Property(e => e.OrganizationName)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VSystemUserPermissionColumn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#User#Permission#Column");

                entity.Property(e => e.ColumnArea).HasMaxLength(100);

                entity.Property(e => e.ColumnId).HasColumnName("ColumnID");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VSystemUserPermissionMainAction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#User#Permission#MainAction");

                entity.Property(e => e.ClassName).HasMaxLength(250);

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<VSystemUserPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSystem#User#Person");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PersonIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");
            });

            modelBuilder.Entity<VTargetIndicatorHelper10>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTargetIndicator#Helper10");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.Nvalue)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("nvalue");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VTargetIndicatorHelper12>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTargetIndicator#Helper12");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdName)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Name");

                entity.Property(e => e.WorkName).HasMaxLength(1000);
            });

            modelBuilder.Entity<VTargetIndicatorProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTargetIndicator#Project");

                entity.Property(e => e.Koeff).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("ProjectID_Code");

                entity.Property(e => e.ProjectIdName)
                    .HasMaxLength(1000)
                    .HasColumnName("ProjectID_Name");

                entity.Property(e => e.ProjectNum)
                    .HasMaxLength(50)
                    .HasColumnName("Project_Num");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VTargetIndicatorTargetIndicator>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTargetIndicator#TargetIndicator");

                entity.Property(e => e.F0).HasMaxLength(500);

                entity.Property(e => e.F0Print)
                    .HasMaxLength(553)
                    .HasColumnName("F0_Print");

                entity.Property(e => e.F1).HasMaxLength(500);

                entity.Property(e => e.IndicatorId).HasColumnName("IndicatorID");

                entity.Property(e => e.IndicatorName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.IndicatorNum).HasMaxLength(50);

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SFormat)
                    .HasMaxLength(100)
                    .HasColumnName("sFormat");

                entity.Property(e => e.SY0)
                    .HasMaxLength(20)
                    .HasColumnName("sY0");

                entity.Property(e => e.SY1)
                    .HasMaxLength(20)
                    .HasColumnName("sY1");

                entity.Property(e => e.SY10)
                    .HasMaxLength(20)
                    .HasColumnName("sY10");

                entity.Property(e => e.SY2)
                    .HasMaxLength(20)
                    .HasColumnName("sY2");

                entity.Property(e => e.SY3)
                    .HasMaxLength(20)
                    .HasColumnName("sY3");

                entity.Property(e => e.SY4)
                    .HasMaxLength(20)
                    .HasColumnName("sY4");

                entity.Property(e => e.SY5)
                    .HasMaxLength(20)
                    .HasColumnName("sY5");

                entity.Property(e => e.SY6)
                    .HasMaxLength(20)
                    .HasColumnName("sY6");

                entity.Property(e => e.SY7)
                    .HasMaxLength(20)
                    .HasColumnName("sY7");

                entity.Property(e => e.SY8)
                    .HasMaxLength(20)
                    .HasColumnName("sY8");

                entity.Property(e => e.SY9)
                    .HasMaxLength(20)
                    .HasColumnName("sY9");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.VersionIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Name");

                entity.Property(e => e.VersionIdparent).HasColumnName("VersionIDParent");

                entity.Property(e => e.Y0).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y10).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y4).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y5).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y6).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y7).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y8).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y9).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<VTargetIndicatorTargetIndicatorEtalon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTargetIndicator#TargetIndicator#Etalon");

                entity.Property(e => e.F0).HasMaxLength(500);

                entity.Property(e => e.F1).HasMaxLength(500);

                entity.Property(e => e.IndicatorId).HasColumnName("IndicatorID");

                entity.Property(e => e.IndicatorName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IndicatorNum).HasMaxLength(50);

                entity.Property(e => e.MeasureIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SFormat)
                    .HasMaxLength(100)
                    .HasColumnName("sFormat");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.VersionIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Name");

                entity.Property(e => e.Y0).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y1).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y10).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y2).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y4).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y5).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y6).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y7).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y8).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Y9).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<VTargetIndicatorTargetIndicatorWorkPlace>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTargetIndicator#TargetIndicatorWorkPlace");

                entity.Property(e => e.F0).HasMaxLength(500);

                entity.Property(e => e.F1).HasMaxLength(500);

                entity.Property(e => e.IndicatorId).HasColumnName("IndicatorID");

                entity.Property(e => e.IndicatorName).HasMaxLength(4000);

                entity.Property(e => e.IndicatorNum).HasMaxLength(50);

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.NYear).HasColumnName("nYear");

                entity.Property(e => e.Nvalue)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("nvalue");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.VersionIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Name");

                entity.Property(e => e.VersionIdparent).HasColumnName("VersionIDParent");
            });

            modelBuilder.Entity<VTaskElement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTask#Element");

                entity.Property(e => e.ChangeTypeCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ChangeType_Code");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.DictionaryValueIdCode)
                    .HasMaxLength(255)
                    .HasColumnName("DictionaryValueID_Code");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.ElementTypeCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Code");

                entity.Property(e => e.ElementTypeName)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Name");

                entity.Property(e => e.ElementValue1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Element_Value");

                entity.Property(e => e.EventTypeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.ExternalDocCount).HasColumnName("ExternalDoc_Count");

                entity.Property(e => e.GroupName).HasMaxLength(260);

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PersonIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.Property(e => e.StructurePath).HasColumnName("Structure_Path");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserName).HasMaxLength(250);

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");
            });

            modelBuilder.Entity<VTaskElementByStep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTask#Element#ByStep");

                entity.Property(e => e.ChangeTypeCode)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ChangeType_Code");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.DictionaryValueIdCode)
                    .HasMaxLength(255)
                    .HasColumnName("DictionaryValueID_Code");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.ElementTypeCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Code");

                entity.Property(e => e.ElementTypeName)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Name");

                entity.Property(e => e.ElementValue1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Element_Value");

                entity.Property(e => e.EventTypeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.ExternalDocCount).HasColumnName("ExternalDoc_Count");

                entity.Property(e => e.GroupName).HasMaxLength(260);

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PersonIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.Property(e => e.StructurePath).HasColumnName("Structure_Path");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskStepRid).HasColumnName("TaskStepRID");

                entity.Property(e => e.UserName).HasMaxLength(250);

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");
            });

            modelBuilder.Entity<VTaskElementLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTask#Element#Light");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VTaskHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTask#History");

                entity.Property(e => e.ActionTypeCode)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("ActionType_Code");

                entity.Property(e => e.Content).HasMaxLength(2000);

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.ElementIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("ElementID_Code");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PersonIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateDate).HasColumnType("date");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<VTaskResultValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTask#ResultValue");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.DictionaryValueIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("DictionaryValueID_Code");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.ElementTypeCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Code");

                entity.Property(e => e.ElementTypeName)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Name");

                entity.Property(e => e.ElementValue)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Element_Value");

                entity.Property(e => e.ExternalDocCount).HasColumnName("ExternalDoc_Count");

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.OldDateFrom).HasColumnType("date");

                entity.Property(e => e.OldDateTo).HasColumnType("date");

                entity.Property(e => e.OldDictionaryIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("OldDictionaryID_Code");

                entity.Property(e => e.OldValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ProposedDateFrom).HasColumnType("date");

                entity.Property(e => e.ProposedDateTo).HasColumnType("date");

                entity.Property(e => e.ProposedDictionaryId).HasColumnName("ProposedDictionaryID");

                entity.Property(e => e.ProposedDictionaryIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("ProposedDictionaryID_Code");

                entity.Property(e => e.ProposedValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.Property(e => e.TaskElementId).HasColumnName("TaskElementID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskStepId).HasColumnName("TaskStepID");

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VTaskResultValueLight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTask#ResultValue#Light");

                entity.Property(e => e.ProposedDateFrom).HasColumnType("date");

                entity.Property(e => e.ProposedDateTo).HasColumnType("date");

                entity.Property(e => e.ProposedValue).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VTaskStep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTask#Step");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DelayReason).HasMaxLength(2000);

                entity.Property(e => e.ExecDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExternalDocCount).HasColumnName("ExternalDoc_Count");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RoleToId).HasColumnName("RoleToID");

                entity.Property(e => e.RoleToIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RoleToID_Code");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("State_Code");

                entity.Property(e => e.TaskPeriod).HasColumnName("Task_Period");

                entity.Property(e => e.UserFromId).HasColumnName("UserFromID");

                entity.Property(e => e.UserFromIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("UserFromID_Code");

                entity.Property(e => e.UserName).HasMaxLength(250);

                entity.Property(e => e.UserToId).HasColumnName("UserToID");

                entity.Property(e => e.UserToIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("UserToID_Code");
            });

            modelBuilder.Entity<VTaskStepElement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTask#Step#Element");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.DictionaryValueIdCode)
                    .HasMaxLength(255)
                    .HasColumnName("DictionaryValueID_Code");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.ElementTypeCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Code");

                entity.Property(e => e.ElementTypeName)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ElementType_Name");

                entity.Property(e => e.ElementValue1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Element_Value");

                entity.Property(e => e.EventTypeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("EventTypeID_Code");

                entity.Property(e => e.ExternalDocCount).HasColumnName("ExternalDoc_Count");

                entity.Property(e => e.GroupName).HasMaxLength(2000);

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.PersonIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("PersonID_Code");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("State_Name");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.StructurePath).HasColumnName("Structure_Path");

                entity.Property(e => e.TaskElementId).HasColumnName("TaskElementID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserName).HasMaxLength(250);

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Code");
            });

            modelBuilder.Entity<VTaskTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTask#Task");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerIdCode)
                    .HasMaxLength(2000)
                    .HasColumnName("CustomerID_Code");

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.DelayReason).HasMaxLength(2000);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ExecDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExternalDocCount).HasColumnName("ExternalDoc_Count");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SeniorWorksCode)
                    .HasMaxLength(2000)
                    .HasColumnName("SeniorWorks_Code");

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.StageIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("StageID_Code");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("State_Code");

                entity.Property(e => e.TaskPeriod).HasColumnName("Task_Period");

                entity.Property(e => e.TaskTypeId).HasColumnName("TaskTypeID");

                entity.Property(e => e.TaskTypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TaskTypeID_Code");

                entity.Property(e => e.UserName).HasMaxLength(260);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");
            });

            modelBuilder.Entity<VTechnicCompatibility>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Compatibility");

                entity.Property(e => e.CountKa).HasColumnName("CountKA");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SpaceportId).HasColumnName("SpaceportID");

                entity.Property(e => e.SpaceportIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceportID_Code");

                entity.Property(e => e.SpaceportIdName)
                    .HasMaxLength(260)
                    .HasColumnName("SpaceportID_Name");

                entity.Property(e => e.TypeKaEntryId).HasColumnName("TypeKa_EntryID");

                entity.Property(e => e.TypeKaid).HasColumnName("TypeKAID");

                entity.Property(e => e.TypeKaidCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeKAID_Code");

                entity.Property(e => e.TypeKaidName)
                    .HasMaxLength(50)
                    .HasColumnName("TypeKAID_Name");

                entity.Property(e => e.TypeObid).HasColumnName("TypeOBID");

                entity.Property(e => e.TypeObidCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeOBID_Code");

                entity.Property(e => e.TypeObidName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeOBID_Name");

                entity.Property(e => e.TypeRbEntryId).HasColumnName("TypeRB_EntryID");

                entity.Property(e => e.TypeRbid).HasColumnName("TypeRBID");

                entity.Property(e => e.TypeRbidCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeRBID_Code");

                entity.Property(e => e.TypeRbidName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeRBID_Name");

                entity.Property(e => e.TypeRnEntryId).HasColumnName("TypeRN_EntryID");

                entity.Property(e => e.TypeRnid).HasColumnName("TypeRNID");

                entity.Property(e => e.TypeRnidCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeRNID_Code");

                entity.Property(e => e.TypeRnidName)
                    .HasMaxLength(1000)
                    .HasColumnName("TypeRNID_Name");
            });

            modelBuilder.Entity<VTechnicParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Param");

                entity.Property(e => e.DataType)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.LinkText).HasMaxLength(2000);

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("ParamID_Code");

                entity.Property(e => e.ParamIdDataType).HasColumnName("ParamID_DataType");

                entity.Property(e => e.ParamIdName)
                    .HasMaxLength(260)
                    .HasColumnName("ParamID_Name");

                entity.Property(e => e.ParamTypeCode)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ParamType_Code");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.ValueN1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValueN2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.VersionIdName)
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Name");
            });

            modelBuilder.Entity<VTechnicParamForTargetIndicator>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Param#ForTargetIndicator");

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.LinkText).HasMaxLength(2000);

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("ParamID_Code");

                entity.Property(e => e.ParamIdDataType).HasColumnName("ParamID_DataType");

                entity.Property(e => e.ParamIdName)
                    .HasMaxLength(260)
                    .HasColumnName("ParamID_Name");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.ValueN1).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ValueN2).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VTechnicStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Status");

                entity.Property(e => e.DocumentNote).HasMaxLength(250);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("State_Code");

                entity.Property(e => e.StateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VTechnicType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Type");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.CnidCode)
                    .HasMaxLength(50)
                    .HasColumnName("CNID_Code");

                entity.Property(e => e.CnidName)
                    .HasMaxLength(260)
                    .HasColumnName("CNID_Name");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.KkidName)
                    .HasMaxLength(260)
                    .HasColumnName("KKID_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PlanSas)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PlanSAS");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VTechnicTypeKa>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Type#KA");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.CnidCode)
                    .HasMaxLength(260)
                    .HasColumnName("CNID_Code");

                entity.Property(e => e.CnidName)
                    .HasMaxLength(260)
                    .HasColumnName("CNID_Name");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.IsBudget).HasColumnName("isBudget");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.KkidDocNum).HasColumnName("KKID_DocNum");

                entity.Property(e => e.KkidName)
                    .HasMaxLength(1000)
                    .HasColumnName("KKID_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PlanSas)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PlanSAS");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SpaceSystemCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystem_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VTechnicTypeKaAnalog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Type#KA#Analog");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.CnidCode)
                    .HasMaxLength(260)
                    .HasColumnName("CNID_Code");

                entity.Property(e => e.CnidName)
                    .HasMaxLength(260)
                    .HasColumnName("CNID_Name");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.KkidDocNum).HasColumnName("KKID_DocNum");

                entity.Property(e => e.KkidName)
                    .HasMaxLength(1000)
                    .HasColumnName("KKID_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PlanSas)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PlanSAS");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SpaceSystemCode)
                    .HasMaxLength(50)
                    .HasColumnName("SpaceSystem_Code");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VTechnicTypeOb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Type#OB");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VTechnicTypeParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Type#Param");

                entity.Property(e => e.DataType)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryValueId).HasColumnName("DictionaryValueID");

                entity.Property(e => e.LinkText).HasMaxLength(2000);

                entity.Property(e => e.MeasureIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("MeasureID_Code");

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("ParamID_Code");

                entity.Property(e => e.ParamIdDataType).HasColumnName("ParamID_DataType");

                entity.Property(e => e.ParamIdName)
                    .HasMaxLength(260)
                    .HasColumnName("ParamID_Name");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.VersionIdName)
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Name");
            });

            modelBuilder.Entity<VTechnicTypeRb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Type#RB");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.CnidCode)
                    .HasMaxLength(50)
                    .HasColumnName("CNID_Code");

                entity.Property(e => e.CnidName)
                    .HasMaxLength(260)
                    .HasColumnName("CNID_Name");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.KkidName)
                    .HasMaxLength(260)
                    .HasColumnName("KKID_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PlanSas)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PlanSAS");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VTechnicTypeRn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTechnic#Type#RN");

                entity.Property(e => e.ClassRn).HasColumnName("ClassRN");

                entity.Property(e => e.ClassRnCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClassRN_Code");

                entity.Property(e => e.Cnid).HasColumnName("CNID");

                entity.Property(e => e.CnidCode)
                    .HasMaxLength(50)
                    .HasColumnName("CNID_Code");

                entity.Property(e => e.CnidName)
                    .HasMaxLength(260)
                    .HasColumnName("CNID_Name");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Kkid).HasColumnName("KKID");

                entity.Property(e => e.KkidCode)
                    .HasMaxLength(50)
                    .HasColumnName("KKID_Code");

                entity.Property(e => e.KkidName)
                    .HasMaxLength(260)
                    .HasColumnName("KKID_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PlanSas)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PlanSAS");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VTmpParamValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTmp#Param#Value");

                entity.Property(e => e.LinkText1).HasMaxLength(2000);

                entity.Property(e => e.LinkText10).HasMaxLength(2000);

                entity.Property(e => e.LinkText11).HasMaxLength(2000);

                entity.Property(e => e.LinkText12).HasMaxLength(2000);

                entity.Property(e => e.LinkText13).HasMaxLength(2000);

                entity.Property(e => e.LinkText14).HasMaxLength(2000);

                entity.Property(e => e.LinkText15).HasMaxLength(2000);

                entity.Property(e => e.LinkText16).HasMaxLength(2000);

                entity.Property(e => e.LinkText17).HasMaxLength(2000);

                entity.Property(e => e.LinkText18).HasMaxLength(2000);

                entity.Property(e => e.LinkText19).HasMaxLength(2000);

                entity.Property(e => e.LinkText2).HasMaxLength(2000);

                entity.Property(e => e.LinkText20).HasMaxLength(2000);

                entity.Property(e => e.LinkText3).HasMaxLength(2000);

                entity.Property(e => e.LinkText4).HasMaxLength(2000);

                entity.Property(e => e.LinkText5).HasMaxLength(2000);

                entity.Property(e => e.LinkText6).HasMaxLength(2000);

                entity.Property(e => e.LinkText7).HasMaxLength(2000);

                entity.Property(e => e.LinkText8).HasMaxLength(2000);

                entity.Property(e => e.LinkText9).HasMaxLength(2000);

                entity.Property(e => e.NPar1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar1");

                entity.Property(e => e.NPar10)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar10");

                entity.Property(e => e.NPar11)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar11");

                entity.Property(e => e.NPar12)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar12");

                entity.Property(e => e.NPar13)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar13");

                entity.Property(e => e.NPar14)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar14");

                entity.Property(e => e.NPar15)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar15");

                entity.Property(e => e.NPar16)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar16");

                entity.Property(e => e.NPar17)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar17");

                entity.Property(e => e.NPar18)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar18");

                entity.Property(e => e.NPar19)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar19");

                entity.Property(e => e.NPar2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar2");

                entity.Property(e => e.NPar20)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar20");

                entity.Property(e => e.NPar21)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar21");

                entity.Property(e => e.NPar22)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar22");

                entity.Property(e => e.NPar23)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar23");

                entity.Property(e => e.NPar24)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar24");

                entity.Property(e => e.NPar25)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar25");

                entity.Property(e => e.NPar26)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar26");

                entity.Property(e => e.NPar27)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar27");

                entity.Property(e => e.NPar28)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar28");

                entity.Property(e => e.NPar29)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar29");

                entity.Property(e => e.NPar3)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar3");

                entity.Property(e => e.NPar30)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar30");

                entity.Property(e => e.NPar4)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar4");

                entity.Property(e => e.NPar5)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar5");

                entity.Property(e => e.NPar6)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar6");

                entity.Property(e => e.NPar7)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar7");

                entity.Property(e => e.NPar8)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar8");

                entity.Property(e => e.NPar9)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("nPar9");

                entity.Property(e => e.SPar1).HasColumnName("sPar1");

                entity.Property(e => e.SPar10).HasColumnName("sPar10");

                entity.Property(e => e.SPar11).HasColumnName("sPar11");

                entity.Property(e => e.SPar12).HasColumnName("sPar12");

                entity.Property(e => e.SPar13).HasColumnName("sPar13");

                entity.Property(e => e.SPar14).HasColumnName("sPar14");

                entity.Property(e => e.SPar15).HasColumnName("sPar15");

                entity.Property(e => e.SPar16).HasColumnName("sPar16");

                entity.Property(e => e.SPar17).HasColumnName("sPar17");

                entity.Property(e => e.SPar18).HasColumnName("sPar18");

                entity.Property(e => e.SPar19).HasColumnName("sPar19");

                entity.Property(e => e.SPar2).HasColumnName("sPar2");

                entity.Property(e => e.SPar20).HasColumnName("sPar20");

                entity.Property(e => e.SPar3).HasColumnName("sPar3");

                entity.Property(e => e.SPar4).HasColumnName("sPar4");

                entity.Property(e => e.SPar5).HasColumnName("sPar5");

                entity.Property(e => e.SPar6).HasColumnName("sPar6");

                entity.Property(e => e.SPar7).HasColumnName("sPar7");

                entity.Property(e => e.SPar8).HasColumnName("sPar8");

                entity.Property(e => e.SPar9).HasColumnName("sPar9");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(25);

                entity.Property(e => e.WorkId).HasColumnName("WorkID");
            });

            modelBuilder.Entity<VUserApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserApplications");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(260);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Version).HasMaxLength(50);
            });

            modelBuilder.Entity<VUserApplicationApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserApplication#Application");

                entity.Property(e => e.Application).HasMaxLength(1);

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VUserArpParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserARP#Params");

                entity.Property(e => e.DataMask).HasMaxLength(250);

                entity.Property(e => e.DataTypeCode)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("DataType_Code");

                entity.Property(e => e.DefaultValueDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultValueNum).HasColumnType("numeric(17, 4)");

                entity.Property(e => e.DefaultValueStr).HasMaxLength(250);

                entity.Property(e => e.IsCanGetList).HasColumnName("isCanGetList");

                entity.Property(e => e.IsOutput).HasColumnName("isOUTPUT");

                entity.Property(e => e.IsRid).HasColumnName("isRID");

                entity.Property(e => e.Label).HasMaxLength(250);

                entity.Property(e => e.LinkFieldCode)
                    .HasMaxLength(100)
                    .HasColumnName("LinkField_Code");

                entity.Property(e => e.LinkfieldSysCode)
                    .HasMaxLength(160)
                    .HasColumnName("LINKFIELD_SYS_CODE");

                entity.Property(e => e.LinksectionCode)
                    .HasMaxLength(260)
                    .HasColumnName("LINKSECTION_CODE");

                entity.Property(e => e.LinksectionSysCode)
                    .HasMaxLength(50)
                    .HasColumnName("LINKSECTION_SYS_CODE");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcedureName).HasMaxLength(260);

                entity.Property(e => e.ProcedureParam).HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SDataType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sDataType");

                entity.Property(e => e.SLinkType)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("sLinkType");
            });

            modelBuilder.Entity<VUserArpParamsLinked>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserARP#Params#Linked");

                entity.Property(e => e.AttFieldName).HasMaxLength(50);

                entity.Property(e => e.AttName).HasMaxLength(160);

                entity.Property(e => e.ClassLib).HasMaxLength(250);

                entity.Property(e => e.ClassName).HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SystemName).HasMaxLength(160);
            });

            modelBuilder.Entity<VUserArpParamsList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserARP#Params#List");

                entity.Property(e => e.DataMask).HasMaxLength(250);

                entity.Property(e => e.DataTypeCode)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("DataType_Code");

                entity.Property(e => e.DefaultValue).HasMaxLength(250);

                entity.Property(e => e.DefaultValueDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultValueNum).HasColumnType("numeric(17, 4)");

                entity.Property(e => e.DefaultValueStr).HasMaxLength(250);

                entity.Property(e => e.Label).HasMaxLength(250);

                entity.Property(e => e.LinkFieldCode)
                    .HasMaxLength(524)
                    .HasColumnName("LinkField_Code");

                entity.Property(e => e.LinkFieldCodeShort)
                    .HasMaxLength(100)
                    .HasColumnName("LinkField_Code_Short");

                entity.Property(e => e.LinkSectionCode)
                    .HasMaxLength(260)
                    .HasColumnName("LinkSection_Code");

                entity.Property(e => e.LinkTypeCode)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("LinkType_Code");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureParam).HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VUserArpSection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserARP#Section");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.NArptype).HasColumnName("nARPType");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.PType).HasColumnName("pType");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SArpname)
                    .HasMaxLength(260)
                    .HasColumnName("sARPName");

                entity.Property(e => e.SArptype).HasColumnName("sARPType");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<VUserGraphGraph>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserGraph#Graph");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.GraphTypeId).HasColumnName("GraphTypeID");

                entity.Property(e => e.GraphTypeIdName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("GraphTypeID_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ProcedureName).HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VUserGraphUnload>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserGraph#Unload");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.Graph).HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ProcedureName).HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VUserProcedure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserProcedures");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ProcedureName).HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VUserProcedureProcedure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserProcedure#Procedure");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ProcedureName).HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VUserProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUser#Profile");

                entity.Property(e => e.FileData).HasColumnType("image");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileVersion).HasMaxLength(50);

                entity.Property(e => e.LastOperation).HasColumnType("datetime");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VUserReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserReports");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.PType).HasColumnName("pType");

                entity.Property(e => e.Prc).HasColumnName("PRC");

                entity.Property(e => e.PrcCode)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PRC_CODE");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SType)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("sType");
            });

            modelBuilder.Entity<VUserReportReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserReport#Report");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.PType).HasColumnName("pType");

                entity.Property(e => e.ProcedureId).HasColumnName("ProcedureID");

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SType)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("sType");
            });

            modelBuilder.Entity<VUserReportRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserReport#Role");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<VUserReportSection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserReport#Section");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<VUserReportUnload>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserReport#Unload");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.PType).HasColumnName("pType");

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Report).HasColumnType("image");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.RptData).IsUnicode(false);

                entity.Property(e => e.SType)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("sType");
            });

            modelBuilder.Entity<VUserReportsParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserReports#Params");

                entity.Property(e => e.DataMask).HasMaxLength(250);

                entity.Property(e => e.DefaultValueDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultValueNum).HasColumnType("numeric(17, 4)");

                entity.Property(e => e.DefaultValueStr).HasMaxLength(250);

                entity.Property(e => e.IsCanGetList).HasColumnName("isCanGetList");

                entity.Property(e => e.IsOutput).HasColumnName("isOUTPUT");

                entity.Property(e => e.IsRid).HasColumnName("isRID");

                entity.Property(e => e.Label).HasMaxLength(250);

                entity.Property(e => e.LinkfieldCode)
                    .HasMaxLength(100)
                    .HasColumnName("LINKFIELD_CODE");

                entity.Property(e => e.LinksectionCode)
                    .HasMaxLength(260)
                    .HasColumnName("LINKSECTION_CODE");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcedureParam).HasMaxLength(250);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SDataType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sDataType");

                entity.Property(e => e.SLinkType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sLinkType");
            });

            modelBuilder.Entity<VUserVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUser#Version");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SqluserName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("SQLUserName");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VVersionCompareSpec1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVersion#Compare#Spec1");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.WorkIsDone1).HasColumnName("Work_IsDone1");

                entity.Property(e => e.WorkIsDone2).HasColumnName("Work_IsDone2");

                entity.Property(e => e.WorkPrintName1).HasColumnName("Work_PrintName1");

                entity.Property(e => e.WorkPrintName2).HasColumnName("Work_PrintName2");

                entity.Property(e => e.WorkPriority1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Work_Priority1");

                entity.Property(e => e.WorkPriority2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Work_Priority2");

                entity.Property(e => e.WorkProgNum1).HasColumnName("Work_ProgNum1");

                entity.Property(e => e.WorkProgNum2).HasColumnName("Work_ProgNum2");

                entity.Property(e => e.WorkRank1).HasColumnName("Work_Rank1");

                entity.Property(e => e.WorkRank2).HasColumnName("Work_Rank2");

                entity.Property(e => e.WorkUseInDoc1).HasColumnName("Work_UseInDoc1");

                entity.Property(e => e.WorkUseInDoc2).HasColumnName("Work_UseInDoc2");
            });

            modelBuilder.Entity<VVersionCompareSpec2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVersion#Compare#Spec2");

                entity.Property(e => e.EventName).HasColumnName("Event_Name");

                entity.Property(e => e.EventType).HasColumnName("Event_Type");

                entity.Property(e => e.EventValue1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Event_Value1");

                entity.Property(e => e.EventValue2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Event_Value2");

                entity.Property(e => e.EventYear).HasColumnName("Event_Year");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VVersionCompareSpec3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVersion#Compare#Spec3");

                entity.Property(e => e.EventDateFrom1).HasColumnName("Event_DateFrom1");

                entity.Property(e => e.EventDateFrom2).HasColumnName("Event_DateFrom2");

                entity.Property(e => e.EventDateTo1).HasColumnName("Event_DateTo1");

                entity.Property(e => e.EventDateTo2).HasColumnName("Event_DateTo2");

                entity.Property(e => e.EventName).HasColumnName("Event_Name");

                entity.Property(e => e.EventType).HasColumnName("Event_Type");

                entity.Property(e => e.EventValue1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Event_Value1");

                entity.Property(e => e.EventValue2)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Event_Value2");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VVersionCompareSpec4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVersion#Compare#Spec4");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VVersionTaskResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVersion#TaskResult");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.ElementName)
                    .HasMaxLength(2000)
                    .HasColumnName("Element_Name");

                entity.Property(e => e.ElementState)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Element_State");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RoleToIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("RoleToID_Code");

                entity.Property(e => e.StepNum).HasColumnName("Step_Num");

                entity.Property(e => e.StepState)
                    .IsRequired()
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("Step_State");

                entity.Property(e => e.StructurePath).HasColumnName("Structure_Path");

                entity.Property(e => e.TaskNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Task_Num");

                entity.Property(e => e.TaskState)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Task_State");

                entity.Property(e => e.UserFromIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("UserFromID_Code");

                entity.Property(e => e.UserToIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("UserToID_Code");
            });

            modelBuilder.Entity<VVersionVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVersion#Version");

                entity.Property(e => e.AcceptDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateInfo).HasMaxLength(250);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsRemoved).HasColumnName("isRemoved");

                entity.Property(e => e.LookCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LookName)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.StateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateIdCode)
                    .IsRequired()
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("StateID_Code");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(50)
                    .HasColumnName("Type_Code");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("TypeID_Code");

                entity.Property(e => e.ValidDocDate).HasColumnType("date");

                entity.Property(e => e.ValidDocNum).HasMaxLength(25);

                entity.Property(e => e.VersionFromCode)
                    .HasMaxLength(50)
                    .HasColumnName("VersionFrom_Code");

                entity.Property(e => e.VersionFromId).HasColumnName("VersionFromID");
            });

            modelBuilder.Entity<VWorkAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Agent");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.AgentIdCode)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AgentID_Code");

                entity.Property(e => e.AgentIdName)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasColumnName("AgentID_Name");

                entity.Property(e => e.AgentTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AgentType_Code");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.VersionIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Name");
            });

            modelBuilder.Entity<VWorkCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Code");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VWorkDirection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Direction");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Numb).HasMaxLength(50);

                entity.Property(e => e.Priority).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VWorkDirectionParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Direction#Param");

                entity.Property(e => e.CalcDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DirectionCode)
                    .HasMaxLength(50)
                    .HasColumnName("Direction_Code");

                entity.Property(e => e.IsActual).HasColumnName("isActual");

                entity.Property(e => e.IsBasic).HasColumnName("isBasic");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ParamID_Code");

                entity.Property(e => e.ParamIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("ParamID_Name");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PersonName)
                    .HasMaxLength(2000)
                    .HasColumnName("Person_Name");

                entity.Property(e => e.PersonUserName)
                    .HasMaxLength(260)
                    .HasColumnName("Person_UserName");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.Value).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VWorkDirectionProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Direction#Project");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Num).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");
            });

            modelBuilder.Entity<VWorkDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Document");

                entity.Property(e => e.DocTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DocType_Code");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.DocumentIdDocDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DocumentID_DocDate");

                entity.Property(e => e.DocumentIdDocNum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DocumentID_DocNum");

                entity.Property(e => e.DocumentIdDocTypeId).HasColumnName("DocumentID_DocTypeID");

                entity.Property(e => e.DocumentIdFileName)
                    .HasMaxLength(260)
                    .IsUnicode(false)
                    .HasColumnName("DocumentID_FileName");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VWorkFinanceWorkPlace>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#FinanceWorkPlace");

                entity.Property(e => e.DiffLimitSum).HasColumnType("numeric(38, 4)");

                entity.Property(e => e.LimitSum).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.Property(e => e.Версия)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ВидФинансирования)
                    .HasMaxLength(50)
                    .HasColumnName("Вид финансирования");

                entity.Property(e => e.ЗначениеФинансовогоПоказателя)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Значение финансового показателя");

                entity.Property(e => e.НаименованиеМероприятия)
                    .HasMaxLength(1000)
                    .HasColumnName("Наименование мероприятия");

                entity.Property(e => e.НомерМероприятияВПрограмме)
                    .HasMaxLength(60)
                    .HasColumnName("Номер мероприятия в программе");

                entity.Property(e => e.Подраздел).HasMaxLength(50);

                entity.Property(e => e.ПоказательФинансированияПоГодам).HasColumnName("Показатель финансирования по годам");

                entity.Property(e => e.Пункт).HasMaxLength(50);

                entity.Property(e => e.Раздел).HasMaxLength(311);

                entity.Property(e => e.РегистрационныйНомерМероприятия)
                    .HasMaxLength(60)
                    .HasColumnName("Регистрационный номер мероприятия");

                entity.Property(e => e.СокрНаименование)
                    .HasMaxLength(1000)
                    .HasColumnName("Сокр. наименование");

                entity.Property(e => e.Статья).HasMaxLength(50);

                entity.Property(e => e.ШифрПроекта).HasColumnName("Шифр проекта");
            });

            modelBuilder.Entity<VWorkFinanceWorkPlaceDshb01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#FinanceWorkPlace#DSHB#01");

                entity.Property(e => e.Версия)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ВидФинансирования)
                    .HasMaxLength(50)
                    .HasColumnName("Вид финансирования");

                entity.Property(e => e.ЗначениеФинансовогоПоказателя)
                    .HasColumnType("numeric(38, 4)")
                    .HasColumnName("Значение финансового показателя");

                entity.Property(e => e.ПоказательФинансированияПоГодам).HasColumnName("Показатель финансирования по годам");
            });

            modelBuilder.Entity<VWorkFinanceWorkPlaceDshb03>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#FinanceWorkPlace#DSHB#03");

                entity.Property(e => e.Версия)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ВидФинансирования)
                    .HasMaxLength(50)
                    .HasColumnName("Вид финансирования");

                entity.Property(e => e.ЗначениеФинансовогоПоказателя)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Значение финансового показателя");

                entity.Property(e => e.НаименованиеМероприятия)
                    .HasMaxLength(1000)
                    .HasColumnName("Наименование мероприятия");

                entity.Property(e => e.ПоказательФинансированияПоГодам).HasColumnName("Показатель финансирования по годам");

                entity.Property(e => e.ШифрПроекта).HasColumnName("Шифр проекта");
            });

            modelBuilder.Entity<VWorkFinanceWorkPlaceDshb05>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#FinanceWorkPlace#DSHB#05");

                entity.Property(e => e.Версия)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ВидФинансирования)
                    .HasMaxLength(50)
                    .HasColumnName("Вид финансирования");

                entity.Property(e => e.ЗначениеФинансовогоПоказателя)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Значение финансового показателя");

                entity.Property(e => e.Исполнитель).HasMaxLength(2000);

                entity.Property(e => e.КатегорияКонтрагента)
                    .HasMaxLength(260)
                    .HasColumnName("Категория контрагента");

                entity.Property(e => e.НаименованиеМероприятия)
                    .HasMaxLength(1000)
                    .HasColumnName("Наименование мероприятия");

                entity.Property(e => e.ПоказательФинансированияПоГодам).HasColumnName("Показатель финансирования по годам");
            });

            modelBuilder.Entity<VWorkFinanceWorkPlaceDshb31>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#FinanceWorkPlace#DSHB#31");

                entity.Property(e => e.Code).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Summ).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VWorkOrbitalGroupWorkPlace>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#OrbitalGroupWorkPlace");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.Версия)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ЗначениеКоличественногоПоказателя)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("Значение количественного показателя");

                entity.Property(e => e.КатегорияМероприятия).HasColumnName("Категория мероприятия");

                entity.Property(e => e.КоличествоЗапусковПоГодам)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("Количество запусков по годам");

                entity.Property(e => e.МнемокодМероприятия)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Мнемокод мероприятия");

                entity.Property(e => e.НаименованиеКа).HasColumnName("Наименование КА");

                entity.Property(e => e.НаименованиеМероприятия)
                    .HasMaxLength(1000)
                    .HasColumnName("Наименование мероприятия");

                entity.Property(e => e.НаправлениеМероприятия).HasColumnName("Направление мероприятия");

                entity.Property(e => e.РазгонныйБлок).HasColumnName("Разгонный блок");

                entity.Property(e => e.РазделПодразделМероприятия)
                    .HasMaxLength(260)
                    .HasColumnName("Раздел/подраздел мероприятия");

                entity.Property(e => e.РакетаНоситель).HasColumnName("Ракета-носитель");

                entity.Property(e => e.ТипМероприятия).HasColumnName("Тип мероприятия");

                entity.Property(e => e.ШифрМероприятия)
                    .HasMaxLength(260)
                    .HasColumnName("Шифр мероприятия");
            });

            modelBuilder.Entity<VWorkParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Param");

                entity.Property(e => e.CalculateTypeCode)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("CalculateType_Code");

                entity.Property(e => e.DefaultValueD1).HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultValueD2).HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultValueS).HasMaxLength(2000);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Format)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Formula).HasMaxLength(260);

                entity.Property(e => e.LinkFieldId).HasColumnName("LinkFieldID");

                entity.Property(e => e.LinkFieldIdAttFieldName)
                    .HasMaxLength(50)
                    .HasColumnName("LinkFieldID_AttFieldName");

                entity.Property(e => e.LinkFieldIdAttName)
                    .HasMaxLength(160)
                    .HasColumnName("LinkFieldID_AttName");

                entity.Property(e => e.LinkFieldIdCode)
                    .HasMaxLength(100)
                    .HasColumnName("LinkFieldID_Code");

                entity.Property(e => e.LinkSectionId).HasColumnName("LinkSectionID");

                entity.Property(e => e.LinkSectionIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("LinkSectionID_Code");

                entity.Property(e => e.LinkTypeCode)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("LinkType_Code");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamIdCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ParamID_Code");

                entity.Property(e => e.ParamIdName)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("ParamID_Name");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProcedureName).HasMaxLength(260);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SortNum).HasMaxLength(260);

                entity.Property(e => e.TitleName).HasMaxLength(260);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.VersionIdNum)
                    .HasMaxLength(50)
                    .HasColumnName("VersionID_Num");
            });

            modelBuilder.Entity<VWorkPriorityDshb01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Priority#DSHB#01");

                entity.Property(e => e.BaseRank).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Median).HasColumnType("numeric(38, 8)");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Priority).HasColumnType("numeric(20, 4)");

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.VersionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Version_Code");

                entity.Property(e => e.VersionState)
                    .IsRequired()
                    .HasMaxLength(22)
                    .IsUnicode(false)
                    .HasColumnName("Version_State");

                entity.Property(e => e.WorkCodeCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkCode_Code");
            });

            modelBuilder.Entity<VWorkRelation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Relation");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.WorkInId).HasColumnName("WorkInID");

                entity.Property(e => e.WorkOutId).HasColumnName("WorkOutID");
            });

            modelBuilder.Entity<VWorkSection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Section");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Level1)
                    .HasMaxLength(311)
                    .HasColumnName("level1");

                entity.Property(e => e.Level2)
                    .HasMaxLength(50)
                    .HasColumnName("level2");

                entity.Property(e => e.Level3).HasMaxLength(50);

                entity.Property(e => e.Level4).HasMaxLength(50);

                entity.Property(e => e.NLevel).HasColumnName("nLevel");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VWorkStage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Stage");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VWorkWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Work");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryWorkId).HasColumnName("DictionaryWorkID");

                entity.Property(e => e.DictionaryWorkIdCode)
                    .HasMaxLength(1000)
                    .HasColumnName("DictionaryWorkID_Code");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PrintName).HasMaxLength(1000);

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(260)
                    .HasColumnName("Section_Code");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("SectionID_Code");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.StageIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("StageID_Code");

                entity.Property(e => e.StageIdName)
                    .HasMaxLength(260)
                    .HasColumnName("StageID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkCodeIdName)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Name");
            });

            modelBuilder.Entity<VWorkWorkRp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Work#RP");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryWorkId).HasColumnName("DictionaryWorkID");

                entity.Property(e => e.DictionaryWorkIdCode)
                    .HasMaxLength(1000)
                    .HasColumnName("DictionaryWorkID_Code");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Expr1).HasMaxLength(50);

                entity.Property(e => e.Expr2).HasMaxLength(260);

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectIdCode).HasColumnName("ProjectID_Code");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.SectionCode)
                    .HasMaxLength(260)
                    .HasColumnName("Section_Code");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionIdCode)
                    .HasMaxLength(260)
                    .HasColumnName("SectionID_Code");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.StageIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("StageID_Code");

                entity.Property(e => e.StageIdName)
                    .HasMaxLength(260)
                    .HasColumnName("StageID_Name");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionIdCode)
                    .IsRequired()
                    .HasMaxLength(260)
                    .HasColumnName("VersionID_Code");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.Property(e => e.WorkCodeIdCode)
                    .HasMaxLength(50)
                    .HasColumnName("WorkCodeID_Code");

                entity.Property(e => e.WorkCodeIdName)
                    .HasMaxLength(260)
                    .HasColumnName("WorkCodeID_Name");
            });

            modelBuilder.Entity<VWorkWorkRpHelper>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vWork#Work#RP#Helper");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<VersionCopyHelper>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK_Helper#Copy");

                entity.ToTable("Version#Copy#Helper");

                entity.HasIndex(e => new { e.Ridold, e.ProcessId }, "index_434_433_Version#Copy#Helper");

                entity.HasIndex(e => new { e.Ridold, e.ProcessId }, "index_464_463_Version#Copy#Helper");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Ridnew).HasColumnName("RIDNEW");

                entity.Property(e => e.Ridold).HasColumnName("RIDOLD");
            });

            modelBuilder.Entity<VersionVersion>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Version#__CAFF41322BBA97F4");

                entity.ToTable("Version#Version");

                entity.HasIndex(e => new { e.Rid, e.Name, e.Code }, "IDX_Version_RID_Code_Name");

                entity.HasIndex(e => new { e.Rid, e.IsRemoved }, "IDX_Version_RID_isRemoved");

                entity.HasIndex(e => e.Rid, "_dta_index_Version#Version_5_755585830__K1_14");

                entity.HasIndex(e => e.Rid, "_dta_index_Version#Version_5_755585830__K1_2_3_14");

                entity.HasIndex(e => e.Rid, "_dta_index_Version#Version_6_755585830__K1_2");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AcceptDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateInfo).HasMaxLength(250);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.IsRemoved).HasColumnName("isRemoved");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.Num)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.StateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.ValidDocDate).HasColumnType("date");

                entity.Property(e => e.ValidDocNum).HasMaxLength(25);

                entity.Property(e => e.VersionFromId).HasColumnName("VersionFromID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Version#Version_Parent");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.VersionVersions)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Version#Version_TypeID");
            });

            modelBuilder.Entity<WorkAgent>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Work#Age__CAFF413211396F54");

                entity.ToTable("Work#Agent");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_RID");

                entity.HasIndex(e => e.WorkId, "_dta_index_Work#Agent_5_1088111017__K2_5_6_8");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.WorkAgents)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Work#Agen__Agent__3D54C988");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.WorkAgents)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK_Work#Agent_VersionID");
            });

            modelBuilder.Entity<WorkCode>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Work#Cod__CAFF41321C093567");

                entity.ToTable("Work#Code");

                entity.HasIndex(e => e.Rid, "_dta_index_Work#Code_6_336108338__K1_2");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.WorkCodes)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Work#Code__Catal__3E48EDC1");
            });

            modelBuilder.Entity<WorkDirection>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Work#Direction");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(2000);

                entity.Property(e => e.Numb).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkDirectionParam>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Work#Direction#Param");

                entity.Property(e => e.Rid)
                    .ValueGeneratedNever()
                    .HasColumnName("RID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.WorkDirectionParams)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Work#Direction#Param_ParentID");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.WorkDirectionParams)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Work#Direction#Param_VersionID");
            });

            modelBuilder.Entity<WorkDocument>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Work#Doc__CAFF4132DF5828F3");

                entity.ToTable("Work#Document");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.WorkDocuments)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Work#Docu__Docum__3F3D11FA");
            });

            modelBuilder.Entity<WorkParam>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Work#Param");

                entity.HasIndex(e => new { e.LinkFieldId, e.Rid }, "IDX_LinkField");

                entity.HasIndex(e => e.VersionId, "IDX_VersionID_RID");

                entity.HasIndex(e => e.Rid, "NonClusteredIndex-20170713-122149");

                entity.HasIndex(e => e.WorkId, "index_382_381_Work#Param");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ColNum).HasDefaultValueSql("((1))");

                entity.Property(e => e.DefaultValueD1).HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultValueD2).HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultValueS).HasMaxLength(2000);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Format)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LinkFieldId).HasColumnName("LinkFieldID");

                entity.Property(e => e.LinkSectionId).HasColumnName("LinkSectionID");

                entity.Property(e => e.LinkType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.RowNum).HasDefaultValueSql("((1))");

                entity.Property(e => e.SortNum).HasMaxLength(260);

                entity.Property(e => e.TitleName).HasMaxLength(260);

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkId).HasColumnName("WorkID");

                entity.HasOne(d => d.LinkField)
                    .WithMany(p => p.WorkParams)
                    .HasForeignKey(d => d.LinkFieldId)
                    .HasConstraintName("FK__Work#Para__LinkF__430DA2DE");

                entity.HasOne(d => d.LinkSection)
                    .WithMany(p => p.WorkParams)
                    .HasForeignKey(d => d.LinkSectionId)
                    .HasConstraintName("FK__Work#Para__LinkS__42197EA5");

                entity.HasOne(d => d.Param)
                    .WithMany(p => p.WorkParams)
                    .HasForeignKey(d => d.ParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Work#Para__Param__40313633");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.WorkParams)
                    .HasForeignKey(d => d.VersionId)
                    .HasConstraintName("FK__Work#Para__Versi__41255A6C");
            });

            modelBuilder.Entity<WorkRelation>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Work#Rel__CAFF41324C4A3542");

                entity.ToTable("Work#Relation");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.WorkInId).HasColumnName("WorkInID");

                entity.Property(e => e.WorkOutId).HasColumnName("WorkOutID");
            });

            modelBuilder.Entity<WorkSection>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("Work#Section");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Work#Section_Parent");
            });

            modelBuilder.Entity<WorkStage>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Work#Sta__CAFF4132DB17D27D");

                entity.ToTable("Work#Stage");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CatalogId).HasColumnName("CatalogID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(260);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.WorkStages)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Work#Stag__Catal__4401C717");
            });

            modelBuilder.Entity<WorkWork>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Work#Wor__CAFF4132D0FE0CAE");

                entity.ToTable("Work#Work");

                entity.HasIndex(e => e.ProjectId, "IDX_ProjectID");

                entity.HasIndex(e => e.VersionId, "IX_Work#Work_VersionID");

                entity.HasIndex(e => e.VersionId, "IX_Work#Work_missing_1");

                entity.HasIndex(e => new { e.TypeId, e.VersionId, e.ParentId }, "IX_Work#Work_missing_116");

                entity.HasIndex(e => new { e.VersionId, e.ParentId }, "IX_Work#Work_missing_2448");

                entity.HasIndex(e => e.ParentId, "IX_Work#Work_missing_2450");

                entity.HasIndex(e => new { e.Code, e.VersionId }, "IX_Work#Work_missing_7");

                entity.HasIndex(e => e.VersionId, "missing_index_610_609_Work#Work");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DictionaryWorkId).HasColumnName("DictionaryWorkID");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Name).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(2000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ProgNum).HasMaxLength(50);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Rank).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShortName).HasMaxLength(260);

                entity.Property(e => e.StageId).HasColumnName("StageID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.WorkCodeId).HasColumnName("WorkCodeID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.WorkWorkCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Work#Work__Categ__47D257FB");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.WorkWorks)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Work#Work__Entry__4BA2E8DF");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Work#Work_ParentID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.WorkWorks)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Work#Work_Project#Project");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.WorkWorks)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Work#Work_SectionID");

                entity.HasOne(d => d.Stage)
                    .WithMany(p => p.WorkWorks)
                    .HasForeignKey(d => d.StageId)
                    .HasConstraintName("FK__Work#Work__Stage__44F5EB50");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.WorkWorkTypes)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Work#Work__TypeI__45EA0F89");

                entity.HasOne(d => d.Version)
                    .WithMany(p => p.WorkWorks)
                    .HasForeignKey(d => d.VersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Work#Work__Versi__48C67C34");

                entity.HasOne(d => d.WorkCode)
                    .WithMany(p => p.WorkWorks)
                    .HasForeignKey(d => d.WorkCodeId)
                    .HasConstraintName("FK__Work#Work__WorkC__46DE33C2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
