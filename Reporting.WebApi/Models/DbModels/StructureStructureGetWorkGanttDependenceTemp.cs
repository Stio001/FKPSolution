using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class StructureStructureGetWorkGanttDependenceTemp
    {
        public Guid Keyid { get; set; }
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public int NType { get; set; }
        public string UserName { get; set; }
        public Guid? ProcessId { get; set; }
        public Guid Mainid { get; set; }
    }
}
