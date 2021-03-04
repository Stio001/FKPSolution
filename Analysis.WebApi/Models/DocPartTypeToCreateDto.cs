using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analysis.WebApi.Models
{
    public class DocPartTypeToCreateDto
    {
        public string Name { get; set; }
        public string KeyWords { get; set; }

        public Guid DocTypeId { get; set; }
    }
}
