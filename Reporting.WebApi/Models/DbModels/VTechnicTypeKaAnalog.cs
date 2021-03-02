using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTechnicTypeKaAnalog
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid EntryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? PlanSas { get; set; }
        public Guid? Kkid { get; set; }
        public Guid? Cnid { get; set; }
        public string KkidCode { get; set; }
        public string KkidName { get; set; }
        public int? KkidDocNum { get; set; }
        public string CnidCode { get; set; }
        public string CnidName { get; set; }
        public int? Composition { get; set; }
        public string SpaceSystemCode { get; set; }
        public Guid VersionId { get; set; }
    }
}
