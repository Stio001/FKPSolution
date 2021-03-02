using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ExternalDocument
    {
        public ExternalDocument()
        {
            WorkDocuments = new HashSet<WorkDocument>();
        }

        public Guid Rid { get; set; }
        public string DocNum { get; set; }
        public DateTime? DocDate { get; set; }
        public DateTime? ImportDate { get; set; }
        public string Note { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public Guid? AgentId { get; set; }
        public string ExternalNum { get; set; }
        public DateTime? DirectDate { get; set; }
        public Guid CatalogId { get; set; }
        public Guid? DocTypeId { get; set; }

        public virtual AgentAgent Agent { get; set; }
        public virtual CatalogCatalog Catalog { get; set; }
        public virtual DictionaryDictionary DocType { get; set; }
        public virtual ICollection<WorkDocument> WorkDocuments { get; set; }
    }
}
