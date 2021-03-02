using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class MmWorkPersonParam
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid ManagerId { get; set; }
        public short Param1 { get; set; }
        public short Param2 { get; set; }
        public short Param3 { get; set; }
        public short Param4 { get; set; }
        public string Note { get; set; }

        public virtual AgentPerson Manager { get; set; }
        public virtual MmWorkPerson Parent { get; set; }
    }
}
