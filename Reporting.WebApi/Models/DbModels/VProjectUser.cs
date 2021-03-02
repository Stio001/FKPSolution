using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VProjectUser
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string RoleIdCode { get; set; }
        public string UserIdCode { get; set; }
        public string SqluserName { get; set; }
        public string Num { get; set; }
        public string ProjectIdCode { get; set; }
        public string ProjectIdName { get; set; }
    }
}
