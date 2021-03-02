using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VGlobalGlobalEntryListRole
    {
        public Guid Rid { get; set; }
        public string RoleName { get; set; }
        public Guid ParentId { get; set; }
    }
}
