using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class OrbitalGroupVariantPlan
    {
        public Guid Rid { get; set; }
        public Guid? DictionaryId { get; set; }
        public Guid ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? Cnid { get; set; }
        public string CnidCode { get; set; }
        public int? DocNum { get; set; }
        public int? Composition { get; set; }

        public virtual OrbitalGroupVariant Parent { get; set; }
    }
}
