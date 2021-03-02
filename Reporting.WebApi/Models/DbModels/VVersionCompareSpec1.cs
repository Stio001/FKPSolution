using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VVersionCompareSpec1
    {
        public Guid? Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string CompareTypeInfo { get; set; }
        public string DiffereceType { get; set; }
        public string DiffereceType1 { get; set; }
        public string WorkProgNum1 { get; set; }
        public string WorkRank1 { get; set; }
        public decimal? WorkPriority1 { get; set; }
        public string WorkIsDone1 { get; set; }
        public string WorkUseInDoc1 { get; set; }
        public string WorkPrintName1 { get; set; }
        public string WorkProgNum2 { get; set; }
        public string WorkRank2 { get; set; }
        public decimal? WorkPriority2 { get; set; }
        public string WorkIsDone2 { get; set; }
        public string WorkUseInDoc2 { get; set; }
        public string WorkPrintName2 { get; set; }
    }
}
