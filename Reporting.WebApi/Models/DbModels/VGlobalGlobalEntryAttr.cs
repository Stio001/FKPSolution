using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VGlobalGlobalEntryAttr
    {
        public Guid Rid { get; set; }
        public Guid EntryRid { get; set; }
        public string SystemName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsRelation { get; set; }
        public string EntryName { get; set; }
        public bool? IsSystem { get; set; }
        public bool? IsOnlyChildUse { get; set; }
        public string ClassName { get; set; }
        public string ClassLib { get; set; }
        public Guid GlobalEntryAttrRid { get; set; }
        public string AttName { get; set; }
        public string AttFieldName { get; set; }
        public string AttCaption { get; set; }
        public string AttType { get; set; }
        public string AttGroup { get; set; }
        public int? AttDomain { get; set; }
        public Guid? ParentId { get; set; }
        public string GlobalName { get; set; }
    }
}
