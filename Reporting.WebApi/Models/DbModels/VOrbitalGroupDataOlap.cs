using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VOrbitalGroupDataOlap
    {
        public int NCount { get; set; }
        public int? NYear { get; set; }
        public string SpacecraftIdCode { get; set; }
        public string RocketIdCode { get; set; }
        public string BoosterIdCode { get; set; }
        public string ObtekatelIdCode { get; set; }
        public string SpaceLaunchIdCode { get; set; }
        public string SpaceSystemIdCode { get; set; }
        public string CategoryIdCode { get; set; }
        public string SpaceLaunchSetIdCode { get; set; }
        public string KkidCode { get; set; }
        public string ClassRnCode { get; set; }
        public string FlightModel { get; set; }
        public Guid ParentId { get; set; }
    }
}
