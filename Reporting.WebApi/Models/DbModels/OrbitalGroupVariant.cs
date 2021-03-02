using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class OrbitalGroupVariant
    {
        public OrbitalGroupVariant()
        {
            OrbitalGroupVariantData = new HashSet<OrbitalGroupVariantDatum>();
            OrbitalGroupVariantPlans = new HashSet<OrbitalGroupVariantPlan>();
        }

        public Guid Rid { get; set; }
        public Guid VersionId { get; set; }
        public int Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateModify { get; set; }

        public virtual VersionVersion Version { get; set; }
        public virtual ICollection<OrbitalGroupVariantDatum> OrbitalGroupVariantData { get; set; }
        public virtual ICollection<OrbitalGroupVariantPlan> OrbitalGroupVariantPlans { get; set; }
    }
}
