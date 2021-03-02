using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DocumentRelation
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
        public decimal? Koeff1 { get; set; }

        public virtual GlobalGlobalEntry EntryIdinNavigation { get; set; }
        public virtual GlobalGlobalEntry EntryIdoutNavigation { get; set; }
    }
}
