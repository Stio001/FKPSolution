using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VUserVersion
    {
        public Guid Rid { get; set; }
        public Guid? UserId { get; set; }
        public string SqluserName { get; set; }
        public Guid? VersionId { get; set; }
    }
}
