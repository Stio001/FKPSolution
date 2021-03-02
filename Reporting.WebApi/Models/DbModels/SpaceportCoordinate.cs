using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SpaceportCoordinate
    {
        public Guid Rid { get; set; }
        public decimal? Lantitude { get; set; }
        public decimal? Longtitude { get; set; }
        public Guid? Spaceport { get; set; }
    }
}
