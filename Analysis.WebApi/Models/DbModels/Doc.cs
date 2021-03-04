using System;
using System.Collections.Generic;

namespace Analysis.WebApi.Models.DbModels
{
    public class Doc
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public List<DocPart> DocParts { get; set; }

        public Guid TypeId { get; set; }
        public DocType Type { get; set; }

        //public Guid? CatalogId { get; set; }
        //public Catalog Catalog { get; set; }
    }
}
