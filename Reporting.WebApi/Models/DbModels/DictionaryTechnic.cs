using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryTechnic
    {
        public DictionaryTechnic()
        {
            DictionaryTechnicAnalogAnalogs = new HashSet<DictionaryTechnicAnalog>();
            DictionaryTechnicAnalogTechnics = new HashSet<DictionaryTechnicAnalog>();
            DictionaryWorkEventTechnics = new HashSet<DictionaryWorkEventTechnic>();
            SpaceLaunchSetSpecs = new HashSet<SpaceLaunchSetSpec>();
            SpacecraftSpacecraftBoosters = new HashSet<SpacecraftSpacecraft>();
            SpacecraftSpacecraftRockets = new HashSet<SpacecraftSpacecraft>();
            SpacecraftSpacecraftSpacecrafts = new HashSet<SpacecraftSpacecraft>();
            TechnicStatuses = new HashSet<TechnicStatus>();
        }

        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string ShortName { get; set; }
        public Guid? TypeId { get; set; }
        public bool? FlightModel { get; set; }
        public Guid? EntryId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual GlobalGlobalEntry Entry { get; set; }
        public virtual ICollection<DictionaryTechnicAnalog> DictionaryTechnicAnalogAnalogs { get; set; }
        public virtual ICollection<DictionaryTechnicAnalog> DictionaryTechnicAnalogTechnics { get; set; }
        public virtual ICollection<DictionaryWorkEventTechnic> DictionaryWorkEventTechnics { get; set; }
        public virtual ICollection<SpaceLaunchSetSpec> SpaceLaunchSetSpecs { get; set; }
        public virtual ICollection<SpacecraftSpacecraft> SpacecraftSpacecraftBoosters { get; set; }
        public virtual ICollection<SpacecraftSpacecraft> SpacecraftSpacecraftRockets { get; set; }
        public virtual ICollection<SpacecraftSpacecraft> SpacecraftSpacecraftSpacecrafts { get; set; }
        public virtual ICollection<TechnicStatus> TechnicStatuses { get; set; }
    }
}
