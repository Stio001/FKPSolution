using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSpaceLaunchSetSpecVersion
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid KaRid { get; set; }
        public Guid? VersionId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
