using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemCopyHelper
    {
        public Guid Rid { get; set; }
        public Guid ProcessId { get; set; }
        public Guid? OldIdfkp { get; set; }
        public Guid? NewIdfkp { get; set; }
        public Guid? OldIdstruct { get; set; }
        public Guid? NewIdstruct { get; set; }
    }
}
