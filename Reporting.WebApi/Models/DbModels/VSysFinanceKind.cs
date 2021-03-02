using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSysFinanceKind
    {
        public Guid? Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? NLevel { get; set; }
        public string Level1 { get; set; }
    }
}
