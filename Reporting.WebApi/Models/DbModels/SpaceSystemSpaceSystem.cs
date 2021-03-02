using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SpaceSystemSpaceSystem
    {
        public SpaceSystemSpaceSystem()
        {
            TechnicTypes = new HashSet<TechnicType>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? Cnid { get; set; }
        public int? DocNum { get; set; }
        public int? Composition { get; set; }

        public virtual DictionaryDictionary Cn { get; set; }
        public virtual ICollection<TechnicType> TechnicTypes { get; set; }
    }
}
