using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TechnicCompatibility
    {
        public Guid Rid { get; set; }
        public Guid? TypeKaid { get; set; }
        public Guid? TypeRnid { get; set; }
        public Guid? TypeRbid { get; set; }
        public int? CountKa { get; set; }
        public Guid? SpaceportId { get; set; }
        public Guid? TypeObid { get; set; }

        public virtual TechnicType TypeKa { get; set; }
        public virtual TechnicType TypeOb { get; set; }
        public virtual TechnicType TypeRb { get; set; }
        public virtual TechnicType TypeRn { get; set; }
    }
}
