using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTechnicCompatibility
    {
        public Guid Rid { get; set; }
        public Guid? TypeKaid { get; set; }
        public Guid? TypeRnid { get; set; }
        public Guid? TypeRbid { get; set; }
        public Guid? TypeObid { get; set; }
        public int? CountKa { get; set; }
        public Guid? TypeKaEntryId { get; set; }
        public string TypeKaidCode { get; set; }
        public string TypeKaidName { get; set; }
        public Guid? TypeRnEntryId { get; set; }
        public string TypeRnidCode { get; set; }
        public string TypeRnidName { get; set; }
        public Guid? TypeRbEntryId { get; set; }
        public string TypeRbidCode { get; set; }
        public string TypeRbidName { get; set; }
        public string TypeObidCode { get; set; }
        public string TypeObidName { get; set; }
        public Guid? SpaceportId { get; set; }
        public string SpaceportIdCode { get; set; }
        public string SpaceportIdName { get; set; }
    }
}
