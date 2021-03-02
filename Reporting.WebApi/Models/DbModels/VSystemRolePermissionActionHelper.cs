using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemRolePermissionActionHelper
    {
        public Guid Rid { get; set; }
        public string AttCaption { get; set; }
        public int Idx { get; set; }
        public int IdxGr { get; set; }
    }
}
