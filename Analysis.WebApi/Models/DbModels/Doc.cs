using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Analysis.WebApi.Models.DbModels
{
    public class Doc
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public bool IsActual { get; set; }
        public List<DocPart> DocParts { get; set; }

        public Guid TypeId { get; set; }
        [JsonIgnore]
        public DocType Type { get; set; }

        public Guid CatalogId { get; set; }
        [JsonIgnore]
        public Catalog Catalog { get; set; }
    }
}
