using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class WorkDirectionParam
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid VersionId { get; set; }
        public decimal? Rank { get; set; }

        public virtual WorkDirection Parent { get; set; }
        public virtual VersionVersion Version { get; set; }
    }
}
