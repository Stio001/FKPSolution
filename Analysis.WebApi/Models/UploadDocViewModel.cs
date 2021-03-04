using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analysis.WebApi.Models
{
    public class UploadDocViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TypeId { get; set; }
    }
}
