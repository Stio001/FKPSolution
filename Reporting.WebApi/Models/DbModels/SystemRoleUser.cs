using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemRoleUser
    {
        public Guid Rid { get; set; }
        public Guid? RoleId { get; set; }
        public Guid? UserId { get; set; }

        public virtual SystemRole Role { get; set; }
        public virtual SystemUser User { get; set; }
    }
}
