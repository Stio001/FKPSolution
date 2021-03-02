using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemSqluser
    {
        public short? SqluserId { get; set; }
        public string SqluserName { get; set; }
        public string SqlloginName { get; set; }
    }
}
