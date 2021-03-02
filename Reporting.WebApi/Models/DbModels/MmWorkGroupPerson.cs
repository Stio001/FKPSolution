using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class MmWorkGroupPerson
    {
        public Guid Rid { get; set; }
        public Guid GroupId { get; set; }
        public Guid PersonId { get; set; }
        public int GroupRole { get; set; }
        public string Note { get; set; }

        public virtual MmWorkGroup Group { get; set; }
        public virtual AgentPerson Person { get; set; }
    }
}
