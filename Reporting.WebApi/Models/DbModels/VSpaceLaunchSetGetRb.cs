using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSpaceLaunchSetGetRb
    {
        public Guid Rid { get; set; }
        public Guid? TypeRbid { get; set; }
        public string Name { get; set; }
        public Guid? SpaceportId { get; set; }
        public Guid? TypeRnid { get; set; }
        public Guid VersionId { get; set; }
        public Guid? RnRid { get; set; }
        public Guid? RbRid { get; set; }
    }
}
