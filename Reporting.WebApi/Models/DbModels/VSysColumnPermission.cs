using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSysColumnPermission
    {
        public bool Editable { get; set; }
        public string AttFieldName { get; set; }
        public string SystemName { get; set; }
        public string AttName { get; set; }
        public string AttType { get; set; }
    }
}
