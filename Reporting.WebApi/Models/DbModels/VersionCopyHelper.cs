using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VersionCopyHelper
    {
        public Guid Rid { get; set; }
        public Guid? Ridold { get; set; }
        public Guid? Ridnew { get; set; }
        public Guid? ProcessId { get; set; }
    }
}
