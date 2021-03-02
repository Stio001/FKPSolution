using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class GlobalGlobalEntryDetail
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public int? DataLevel { get; set; }
        public string NameRead { get; set; }
        public string NameInsert { get; set; }
        public string NameEdit { get; set; }
        public string NameDelete { get; set; }
        public string NameJoin { get; set; }
        public string NamePref { get; set; }
        public string NamePrebuild { get; set; }

        public virtual GlobalGlobalEntry Parent { get; set; }
    }
}
