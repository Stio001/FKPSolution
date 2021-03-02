using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class Organization
    {
        public Organization()
        {
            SystemLicenses = new HashSet<SystemLicense>();
            SystemUserOrganizations = new HashSet<SystemUserOrganization>();
        }

        public Guid Rid { get; set; }
        public Guid AgentId { get; set; }
        public string Code { get; set; }
        public string Note { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        public virtual AgentAgent Agent { get; set; }
        public virtual ICollection<SystemLicense> SystemLicenses { get; set; }
        public virtual ICollection<SystemUserOrganization> SystemUserOrganizations { get; set; }
    }
}
