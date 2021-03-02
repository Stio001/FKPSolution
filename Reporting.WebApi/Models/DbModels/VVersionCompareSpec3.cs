using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VVersionCompareSpec3
    {
        public Guid? Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string CompareTypeInfo { get; set; }
        public string DiffereceType { get; set; }
        public string DiffereceType1 { get; set; }
        public string EventType { get; set; }
        public string EventName { get; set; }
        public int? EventDateFrom1 { get; set; }
        public int? EventDateTo1 { get; set; }
        public int? EventDateFrom2 { get; set; }
        public int? EventDateTo2 { get; set; }
        public decimal? EventValue1 { get; set; }
        public decimal? EventValue2 { get; set; }
    }
}
