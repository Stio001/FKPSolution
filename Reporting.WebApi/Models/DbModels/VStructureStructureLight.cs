using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VStructureStructureLight
    {
        public Guid Rid { get; set; }
        public short? ElementType { get; set; }
        public Guid? ElementId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? VersionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TypeIdCode { get; set; }
        public int? WorkType { get; set; }
    }
}
