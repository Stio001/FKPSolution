using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VStructureRelation
    {
        public Guid Rid { get; set; }
        public Guid DocIn { get; set; }
        public Guid DocOut { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TypeIdCode { get; set; }
        public int? LinkType { get; set; }
        public int? Rank { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
    }
}
