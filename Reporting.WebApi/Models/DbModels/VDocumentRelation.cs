using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDocumentRelation
    {
        public Guid Rid { get; set; }
        public Guid DocIn { get; set; }
        public Guid DocOut { get; set; }
        public Guid EntryIdin { get; set; }
        public Guid EntryIdout { get; set; }
        public int? LinkType { get; set; }
        public int? Rank { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string EntryIdinSystemName { get; set; }
        public string EntryIdinName { get; set; }
        public string EntryIdoutSystemName { get; set; }
        public string EntryIdoutName { get; set; }
        public decimal? Koeff1 { get; set; }
    }
}
