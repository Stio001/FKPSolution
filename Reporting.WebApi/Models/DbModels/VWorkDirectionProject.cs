using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VWorkDirectionProject
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? VersionId { get; set; }
    }
}
