using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TechnicType
    {
        public TechnicType()
        {
            TechnicCompatibilityTypeKas = new HashSet<TechnicCompatibility>();
            TechnicCompatibilityTypeObs = new HashSet<TechnicCompatibility>();
            TechnicCompatibilityTypeRbs = new HashSet<TechnicCompatibility>();
            TechnicCompatibilityTypeRns = new HashSet<TechnicCompatibility>();
            TechnicTypeAnalogAnalogs = new HashSet<TechnicTypeAnalog>();
            TechnicTypeAnalogParents = new HashSet<TechnicTypeAnalog>();
            TechnicTypeParams = new HashSet<TechnicTypeParam>();
        }

        public Guid Rid { get; set; }
        public Guid EntryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ClassRn { get; set; }
        public decimal? PlanSas { get; set; }
        public Guid? Kkid { get; set; }
        public Guid? Cnid { get; set; }
        public byte[] Picture { get; set; }

        public virtual GlobalGlobalEntry Entry { get; set; }
        public virtual SpaceSystemSpaceSystem Kk { get; set; }
        public virtual ICollection<TechnicCompatibility> TechnicCompatibilityTypeKas { get; set; }
        public virtual ICollection<TechnicCompatibility> TechnicCompatibilityTypeObs { get; set; }
        public virtual ICollection<TechnicCompatibility> TechnicCompatibilityTypeRbs { get; set; }
        public virtual ICollection<TechnicCompatibility> TechnicCompatibilityTypeRns { get; set; }
        public virtual ICollection<TechnicTypeAnalog> TechnicTypeAnalogAnalogs { get; set; }
        public virtual ICollection<TechnicTypeAnalog> TechnicTypeAnalogParents { get; set; }
        public virtual ICollection<TechnicTypeParam> TechnicTypeParams { get; set; }
    }
}
