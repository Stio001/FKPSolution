using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemUserOrganization
    {
        public Guid UserId { get; set; }
        public Guid OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual SystemUser User { get; set; }
    }
}
