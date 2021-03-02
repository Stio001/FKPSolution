using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SpaceLaunchSet
    {
        public SpaceLaunchSet()
        {
            SpaceLaunchSetSpecs = new HashSet<SpaceLaunchSetSpec>();
            SpacecraftSpacecrafts = new HashSet<SpacecraftSpacecraft>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? RnRid { get; set; }
        public Guid? RbRid { get; set; }
        public Guid? ObRid { get; set; }
        public Guid? VersionId { get; set; }
        public Guid? CatalogId { get; set; }
        public Guid? SlRid { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual ICollection<SpaceLaunchSetSpec> SpaceLaunchSetSpecs { get; set; }
        public virtual ICollection<SpacecraftSpacecraft> SpacecraftSpacecrafts { get; set; }
    }
}
