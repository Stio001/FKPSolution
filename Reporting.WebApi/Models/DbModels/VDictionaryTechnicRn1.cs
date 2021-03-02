using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryTechnicRn1
    {
        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string ShortName { get; set; }
        public Guid? TypeId { get; set; }
        public string TypeIdCode { get; set; }
        public string TypeIdName { get; set; }
        public bool? FlightModel { get; set; }
        public string SpaceSetName { get; set; }
        public Guid VersionId { get; set; }
        public short? StateId { get; set; }
        public string StateIdCode { get; set; }
        public string RbRidCode { get; set; }
        public DateTime? DateFrom { get; set; }
        public int? ClassRn { get; set; }
        public string ClassRnCode { get; set; }
    }
}
