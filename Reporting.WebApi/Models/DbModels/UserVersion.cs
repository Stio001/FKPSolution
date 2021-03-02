using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class UserVersion
    {
        public Guid Rid { get; set; }
        public Guid? UserId { get; set; }
        public Guid? VersionId { get; set; }

        public virtual SystemUser User { get; set; }
        public virtual VersionVersion Version { get; set; }
    }
}
