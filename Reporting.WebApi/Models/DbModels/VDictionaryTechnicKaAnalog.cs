using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryTechnicKaAnalog
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
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
        public string SpaceSystemIdCode { get; set; }
        public Guid? SpaceSystemId { get; set; }
        public Guid? CategoryId { get; set; }
        public string CategoryIdCode { get; set; }
        public string CategoryIdName { get; set; }
        public Guid? Kkid { get; set; }
        public string KkidName { get; set; }
        public string KkidCode { get; set; }
        public int? KkidDocNum { get; set; }
        public Guid VersionId { get; set; }
        public short? StateId { get; set; }
        public string StateIdCode { get; set; }
        public int? GroupNumber { get; set; }
        public string DocumentNote { get; set; }
        public string RnRidCode { get; set; }
        public string RbRidCode { get; set; }
        public string KaRidCode { get; set; }
        public bool? NCountEvent { get; set; }
        public int? LinkCount { get; set; }
        public int? Composition { get; set; }
        public string SpaceSystemCode { get; set; }
        public DateTime? DateFrom { get; set; }
        public int? FactWorkTime { get; set; }
        public string ExtName { get; set; }
    }
}
