using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VMmWorkGroupPerson
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid PersonId { get; set; }
        public int GroupRole { get; set; }
        public string Note { get; set; }
        public string GroupRoleName { get; set; }
        public string PersonIdCode { get; set; }
    }
}
