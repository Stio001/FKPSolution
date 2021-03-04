using System;
using System.Collections.Generic;

namespace Analysis.WebApi.Models.DbModels
{
    public class DocType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Doc> Docs { get; set; }
        public List<DocPartType> DocPartTypes { get; set; }
    }
}
