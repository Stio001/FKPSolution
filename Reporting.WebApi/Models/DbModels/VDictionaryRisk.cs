using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryRisk
    {
        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public Guid TypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string TypeIdCode { get; set; }
        public string TypeIdName { get; set; }
        public bool? IsActual { get; set; }
    }
}
