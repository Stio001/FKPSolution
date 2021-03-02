using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SpacecraftSpacecraft
    {
        public SpacecraftSpacecraft()
        {
            DictionaryWorkEvents = new HashSet<DictionaryWorkEvent>();
        }

        public Guid Rid { get; set; }
        public Guid VersionId { get; set; }
        public Guid? SpacecraftId { get; set; }
        public Guid? RocketId { get; set; }
        public Guid? BoosterId { get; set; }
        public Guid? SpaceLaunchId { get; set; }
        public DateTime? PlanDateFrom { get; set; }
        public DateTime? PlanDateTo { get; set; }
        public DateTime? FactDateFrom { get; set; }
        public DateTime? FactDateTo { get; set; }
        public int? FactWorkTime { get; set; }
        public int State { get; set; }
        public string Note { get; set; }
        public Guid? SpaceLaunchSetId { get; set; }

        public virtual DictionaryTechnic Booster { get; set; }
        public virtual DictionaryTechnic Rocket { get; set; }
        public virtual DictionaryDictionary SpaceLaunch { get; set; }
        public virtual SpaceLaunchSet SpaceLaunchSet { get; set; }
        public virtual DictionaryTechnic Spacecraft { get; set; }
        public virtual VersionVersion Version { get; set; }
        public virtual ICollection<DictionaryWorkEvent> DictionaryWorkEvents { get; set; }
    }
}
