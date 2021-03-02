using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemAudit
    {
        public Guid Rid { get; set; }
        public string TableName { get; set; }
        public Guid UserRid { get; set; }
        public string Ctype { get; set; }
        public DateTime ChangeTime { get; set; }
        public string UserName { get; set; }
    }
}
