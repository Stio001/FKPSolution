using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VUserArpParamsLinked
    {
        public Guid Rid { get; set; }
        public string ClassLib { get; set; }
        public string ClassName { get; set; }
        public string SystemName { get; set; }
        public string AttName { get; set; }
        public string AttFieldName { get; set; }
    }
}
