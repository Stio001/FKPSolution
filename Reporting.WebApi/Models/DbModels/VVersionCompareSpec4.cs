using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VVersionCompareSpec4
    {
        public Guid? Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string CompareTypeInfo { get; set; }
        public string DiffereceType { get; set; }
        public string DiffereceType1 { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }
}
