using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Analysis.WebApi.Models
{
    public class DocPart
    {
        public Guid Id { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public int PartLevel { get; set; }
        public List<DocPart> ChildDocParts { get; set; }

        public Guid? ParentId { get; set; }
        public DocPart Parent { get; set; }
        
        public Guid DocId { get; set; }
        public Doc Doc { get; set; }
    }
}
