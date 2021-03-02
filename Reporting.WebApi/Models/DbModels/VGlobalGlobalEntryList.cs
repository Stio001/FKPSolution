using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VGlobalGlobalEntryList
    {
        public Guid Rid { get; set; }
        public string SystemName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsRelation { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsOnlyChildUse { get; set; }
        public string ClassName { get; set; }
        public string ClassLib { get; set; }
        public string EditClassName { get; set; }
        public string TypeEntry { get; set; }
        public string ComplexName { get; set; }
    }
}
