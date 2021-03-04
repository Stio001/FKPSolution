using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analysis.WebApi.Models
{
    public class CatalogToCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
    }
}
