using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemCurrentUser
    {
        public Guid Rid { get; set; }
        public string SqluserName { get; set; }
        public int SqluserId { get; set; }
        public string Description { get; set; }
        public Guid PersonId { get; set; }
        public string PersonIdCode { get; set; }
        public string SqlloginName { get; set; }
    }
}
