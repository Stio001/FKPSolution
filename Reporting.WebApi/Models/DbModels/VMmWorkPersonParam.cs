using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VMmWorkPersonParam
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid ManagerId { get; set; }
        public short Param1 { get; set; }
        public short Param2 { get; set; }
        public short Param3 { get; set; }
        public short Param4 { get; set; }
        public string Note { get; set; }
        public string AgentIdCode { get; set; }
        public decimal Param1Value { get; set; }
        public string Param1Name { get; set; }
        public decimal Param2Value { get; set; }
        public string Param2Name { get; set; }
        public decimal Param3Value { get; set; }
        public string Param3Name { get; set; }
        public decimal Param4Value { get; set; }
        public string Param4Name { get; set; }
    }
}
