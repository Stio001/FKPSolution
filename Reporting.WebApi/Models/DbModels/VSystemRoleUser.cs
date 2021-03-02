using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemRoleUser
    {
        public Guid Rid { get; set; }
        public Guid? RoleId { get; set; }
        public string RoleIdCode { get; set; }
        public Guid? UserId { get; set; }
        public string UserIdCode { get; set; }
        public string UserIdName { get; set; }
        public string SqluserName { get; set; }
        public bool? IsAdmin { get; set; }
        public Guid AgentId { get; set; }
        public bool? IsBlock { get; set; }
    }
}
