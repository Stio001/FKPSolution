using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryLinkElement
    {
        public Guid Rid { get; set; }
        public int? Num { get; set; }
        public int? AppNum { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Guid? VersionId { get; set; }
        public Guid DocIn { get; set; }
        public Guid DocOut { get; set; }
        public int? LinkType { get; set; }
        public Guid EntryIdin { get; set; }
        public Guid EntryIdout { get; set; }
    }
}
