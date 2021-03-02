using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VPostDuty
    {
        public Guid Rid { get; set; }
        public string Note { get; set; }
        public Guid PostId { get; set; }
        public string Name { get; set; }
    }
}
