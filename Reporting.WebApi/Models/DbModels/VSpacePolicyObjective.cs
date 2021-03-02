using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSpacePolicyObjective
    {
        public Guid Rid { get; set; }
        public int Num { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public Guid VersionId { get; set; }
    }
}
