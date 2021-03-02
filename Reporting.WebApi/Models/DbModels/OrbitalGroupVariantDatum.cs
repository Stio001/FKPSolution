using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class OrbitalGroupVariantDatum
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid? SpacecraftId { get; set; }
        public string SpacecraftIdCode { get; set; }
        public Guid? RocketId { get; set; }
        public string RocketIdCode { get; set; }
        public Guid? BoosterId { get; set; }
        public string BoosterIdCode { get; set; }
        public Guid? ObtekatelId { get; set; }
        public string ObtekatelIdCode { get; set; }
        public Guid? SpaceLaunchId { get; set; }
        public string SpaceLaunchIdCode { get; set; }
        public Guid? SpaceSystemId { get; set; }
        public string SpaceSystemIdCode { get; set; }
        public Guid? CategoryId { get; set; }
        public string CategoryIdCode { get; set; }
        public Guid? SpaceLaunchSetId { get; set; }
        public string SpaceLaunchSetIdCode { get; set; }
        public Guid? Kkid { get; set; }
        public string KkidCode { get; set; }
        public int? ClassRnid { get; set; }
        public string ClassRnCode { get; set; }
        public int? LaunchPeriod { get; set; }
        public string FlightModel { get; set; }
        public DateTime? PlanDateFrom { get; set; }
        public DateTime? PlanDateTo { get; set; }
        public DateTime? FactDateFrom { get; set; }
        public DateTime? FactDateTo { get; set; }
        public int? PlanWorkTime { get; set; }
        public int? FactWorkTime { get; set; }
        public int? State { get; set; }
        public string StateCode { get; set; }
        public string Note { get; set; }

        public virtual OrbitalGroupVariant Parent { get; set; }
    }
}
