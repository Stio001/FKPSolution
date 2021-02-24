using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analysis.WebApi.Models
{
    public class Doc
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<DocPart> DocParts { get; set; }

        public Guid? TypeId { get; set; }
        public DocType Type { get; set; }
    }
}
