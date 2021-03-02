using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSpacecraftSpacecraftSchedule
    {
        public Guid Rid { get; set; }
        public Guid VersionId { get; set; }
        public Guid? SpacecraftId { get; set; }
        public Guid? RocketId { get; set; }
        public Guid? BoosterId { get; set; }
        public Guid? ObtekatelId { get; set; }
        public Guid? SpaceLaunchId { get; set; }
        public DateTime? PlanDateFrom { get; set; }
        public DateTime? PlanDateTo { get; set; }
        public DateTime? FactDateFrom { get; set; }
        public DateTime? FactDateTo { get; set; }
        public int? FactWorkTime { get; set; }
        public int State { get; set; }
        public string StateCode { get; set; }
        public string Note { get; set; }
        public string VersionCode { get; set; }
        public string VersionIdCode { get; set; }
        public string SpacecraftCode { get; set; }
        public string SpacecraftIdCode { get; set; }
        public string RocketCode { get; set; }
        public string RocketIdCode { get; set; }
        public string RocketTypeName { get; set; }
        public string BoosterCode { get; set; }
        public string BoosterIdCode { get; set; }
        public string BoosterTypeName { get; set; }
        public string ObtekatelCode { get; set; }
        public string ObtekatelIdCode { get; set; }
        public string SpaceLaunchCode { get; set; }
        public string SpaceLaunchIdCode { get; set; }
        public string StateName { get; set; }
        public string SpaceSystemIdCode { get; set; }
        public Guid? SpaceSystemId { get; set; }
        public Guid? CategoryId { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public int? NCountEvent { get; set; }
        public string SpacecraftDescription { get; set; }
        public string SpacecraftShortName { get; set; }
        public Guid? SpaceLaunchSetId { get; set; }
        public string SpaceLaunchSetIdCode { get; set; }
        public string SpaceLaunchSetIdName { get; set; }
        public string FlightModel { get; set; }
        public Guid? Kkid { get; set; }
        public string KkidCode { get; set; }
        public int Y2015 { get; set; }
        public int Y2016 { get; set; }
        public int Y2017 { get; set; }
        public int Y2018 { get; set; }
        public int Y2019 { get; set; }
        public int Y2020 { get; set; }
        public int Y2021 { get; set; }
        public int Y2022 { get; set; }
        public int Y2023 { get; set; }
        public int Y2024 { get; set; }
        public int Y2025 { get; set; }
        public int Y2026 { get; set; }
        public int Y2027 { get; set; }
        public int Y2028 { get; set; }
        public int Y2029 { get; set; }
        public int Y2030 { get; set; }
        public int Y2031 { get; set; }
        public int Y2032 { get; set; }
        public int Y2033 { get; set; }
        public int Y2034 { get; set; }
        public int Y2035 { get; set; }
        public int Y2036 { get; set; }
        public int Y2037 { get; set; }
        public int Y2038 { get; set; }
        public int Y2039 { get; set; }
        public int Y2040 { get; set; }
        public int? LaunchPeriod { get; set; }
        public int? LinkCount { get; set; }
        public string ClassRnCode { get; set; }
        public string SpaceLaunchSetNote { get; set; }
        public bool? IsBudget { get; set; }
        public DateTime? StorageExpirationDateRn { get; set; }
        public DateTime? StorageExpirationDateRb { get; set; }
        public DateTime? StorageExpirationDateOb { get; set; }
        public DateTime? MinimumDate { get; set; }
    }
}
