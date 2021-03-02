using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SchedulerDependency
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? DependentId { get; set; }
        public int Type { get; set; }
    }
}
