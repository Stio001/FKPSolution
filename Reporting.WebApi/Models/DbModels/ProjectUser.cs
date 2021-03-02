using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ProjectUser
    {
        public Guid Rid { get; set; }
        public Guid ProjectId { get; set; }
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }

        public virtual ProjectProject Project { get; set; }
        public virtual SystemUser User { get; set; }
    }
}
