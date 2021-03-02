using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemUserOrganization
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public int HasPermission { get; set; }
    }
}
