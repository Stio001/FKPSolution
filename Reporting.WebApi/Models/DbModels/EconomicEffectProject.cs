using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class EconomicEffectProject
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid ProjectId { get; set; }

        public virtual EconomicEffect Parent { get; set; }
        public virtual ProjectProject Project { get; set; }
    }
}
