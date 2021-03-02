using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemRole
    {
        public Guid Rid { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
