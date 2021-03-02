using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VEconomicEffectProject
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNum { get; set; }
    }
}
