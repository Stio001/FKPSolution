using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VStructureStructureGetWorkGanttResourceTemp
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public decimal? Summ { get; set; }
        public decimal? StageSum { get; set; }
        public string UserName { get; set; }
        public Guid? ProcessId { get; set; }
        public string Color { get; set; }
        public decimal? SummEdit { get; set; }
        public decimal? StageSumEdit { get; set; }
        public int? NType { get; set; }
        public Guid MainRid { get; set; }
        public Guid? KindId { get; set; }
        public string KindIdCode { get; set; }
    }
}
