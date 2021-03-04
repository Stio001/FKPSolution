using System;
using System.Collections.Generic;

namespace Analysis.WebApi.Models.DbModels
{
    public class DocPartType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string KeyWords { get; set; }
        public List<DocPart> DocParts { get; set; }

        public Guid DocTypeId { get; set; }
        public DocType DocType { get; set; }
    }
}
