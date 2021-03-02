using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemUserPerson
    {
        public string SqluserName { get; set; }
        public string PersonIdCode { get; set; }
        public Guid PersonId { get; set; }
    }
}
