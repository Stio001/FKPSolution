using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ExternalFile
    {
        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public string DocPref { get; set; }
        public int? DocNum { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public DateTime? InDate { get; set; }
        public int StateSign { get; set; }
        public Guid? AgentId { get; set; }
        public byte[] Fdata { get; set; }

        public virtual AgentAgent Agent { get; set; }
        public virtual CatalogCatalog Catalog { get; set; }
    }
}
