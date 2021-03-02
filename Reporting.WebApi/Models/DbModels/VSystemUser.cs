using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemUser
    {
        public Guid Rid { get; set; }
        public string SqluserName { get; set; }
        public int SqluserId { get; set; }
        public string Description { get; set; }
        public Guid PersonId { get; set; }
        public string PersonIdCode { get; set; }
        public string SqlloginName { get; set; }
        public bool? IsBlock { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? BlockDate { get; set; }
    }
}
