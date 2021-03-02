using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VUserReportRole
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? RoleId { get; set; }
        public string Name { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
