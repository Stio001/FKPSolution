using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VWorkDirection
    {
        public Guid Rid { get; set; }
        public string Numb { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid VersionId { get; set; }
        public decimal? Rank { get; set; }
        public int? ProjectCount { get; set; }
        public decimal? Priority { get; set; }
    }
}
