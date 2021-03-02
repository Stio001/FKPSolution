using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSpacecraftSpacecraftCalcPlan
    {
        public int? NYear { get; set; }
        public Guid Rid { get; set; }
        public Guid VersionId { get; set; }
        public Guid? SpacecraftId { get; set; }
        public Guid? RocketId { get; set; }
        public Guid? BoosterId { get; set; }
        public Guid? SpaceLaunchId { get; set; }
        public DateTime? PlanDateFrom { get; set; }
        public int? PlanYearFrom { get; set; }
        public int? PlanDateTo { get; set; }
        public int? FactYearFrom { get; set; }
        public DateTime? FactDateTo { get; set; }
        public int? FactWorkTime { get; set; }
        public int State { get; set; }
        public string Note { get; set; }
        public string VersionCode { get; set; }
        public string VersionIdCode { get; set; }
        public string SpacecraftCode { get; set; }
        public string SpacecraftIdCode { get; set; }
        public string RocketCode { get; set; }
        public string RocketIdCode { get; set; }
        public string BoosterCode { get; set; }
        public string BoosterIdCode { get; set; }
        public string SpaceLaunchCode { get; set; }
        public string SpaceLaunchIdCode { get; set; }
        public string StateName { get; set; }
        public int NEx { get; set; }
        public string SpaceSystemIdCode { get; set; }
        public Guid? SpaceSystemId { get; set; }
        public Guid? CategoryId { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public int? IsFlightModel { get; set; }
        public string FlightModel { get; set; }
        public string ObtekatelCode { get; set; }
        public string SpaceLaunchSetIdCode { get; set; }
        public int? Composition { get; set; }
        public string SpaceSystemCode { get; set; }
        public Guid Karid { get; set; }
    }
}
