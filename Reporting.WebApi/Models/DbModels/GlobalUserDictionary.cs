using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class GlobalUserDictionary
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid? CompanyId { get; set; }
        public short NType { get; set; }
        public int? DimInt { get; set; }
        public int? DimFloat { get; set; }
        public int? DimStr { get; set; }
        public string Mask { get; set; }
        public byte[] Icon { get; set; }
    }
}
