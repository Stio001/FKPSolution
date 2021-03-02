using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class UserReportRole
    {
        public Guid Rid { get; set; }
        public Guid? ReportId { get; set; }
        public Guid? RoleId { get; set; }

        public virtual SystemRole Role { get; set; }
    }
}
