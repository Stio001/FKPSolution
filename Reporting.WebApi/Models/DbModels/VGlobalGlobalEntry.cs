using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VGlobalGlobalEntry
    {
        public Guid Rid { get; set; }
        public Guid EntryRid { get; set; }
        public string SystemName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsRelation { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsOnlyChildUse { get; set; }
        public string ClassName { get; set; }
        public string ClassLib { get; set; }
        public string ComplexName { get; set; }
        public Guid? GlobalEntryAttrRid { get; set; }
        public int? AttName { get; set; }
        public int? AttFieldName { get; set; }
        public int? AttCaption { get; set; }
        public int? AttType { get; set; }
        public int? AttGroup { get; set; }
        public int? AttDomain { get; set; }
    }
}
