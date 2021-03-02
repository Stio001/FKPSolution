using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DashboardFilter
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string UserName { get; set; }
        public string FilterValue { get; set; }

        public virtual UserGraphGraph Parent { get; set; }
    }
}
