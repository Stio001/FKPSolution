using System;
using System.Collections.Generic;

namespace Analysis.WebApi.Models.DbModels
{
    public class DocPart
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public int PartLevel { get; set; }
        public List<DocPart> ChildDocParts { get; set; }

        public Guid? DocPartTypeId { get; set; }
        public DocPartType DocPartType { get; set; }

        public Guid? ParentId { get; set; }
        public DocPart Parent { get; set; }
        
        public Guid DocId { get; set; }
        public Doc Doc { get; set; }
    }
}
