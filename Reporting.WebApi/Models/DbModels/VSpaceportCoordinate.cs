using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSpaceportCoordinate
    {
        public Guid Rid { get; set; }
        public decimal? Lantitude { get; set; }
        public decimal? Longtitude { get; set; }
        public Guid? Spaceport { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
