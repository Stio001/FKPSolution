using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSpaceLaunchSetGetRn
    {
        public Guid Rid { get; set; }
        public Guid? TypeRnid { get; set; }
        public string Name { get; set; }
        public Guid? SpaceportId { get; set; }
        public Guid VersionId { get; set; }
        public Guid? RnRid { get; set; }
    }
}
