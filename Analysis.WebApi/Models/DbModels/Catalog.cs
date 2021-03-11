using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Analysis.WebApi.Models.DbModels
{
    public class Catalog
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Doc> Docs { get; set; }

        public Guid? ParentId { get; set; }
        [JsonIgnore]
        public Catalog Parent { get; set; }
    }
}
