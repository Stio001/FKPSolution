using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VExternalFile
    {
        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public string DocPref { get; set; }
        public int? DocNum { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public DateTime? InDate { get; set; }
        public string StateSignName { get; set; }
        public Guid? AgentId { get; set; }
        public string AgentIdCode { get; set; }
        public int StateSign { get; set; }
        public string EntryName { get; set; }
    }
}
