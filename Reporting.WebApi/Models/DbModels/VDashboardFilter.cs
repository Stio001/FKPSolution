using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDashboardFilter
    {
        public Guid? ParentId { get; set; }
        public string FilterValue { get; set; }
        public string UserName { get; set; }
        public Guid Rid { get; set; }
    }
}
