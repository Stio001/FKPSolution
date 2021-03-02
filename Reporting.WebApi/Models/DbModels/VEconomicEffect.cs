using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VEconomicEffect
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid VersionId { get; set; }
        public decimal? Sum1 { get; set; }
        public decimal? Sum2 { get; set; }
        public decimal? Sum3 { get; set; }
        public decimal? Sum4 { get; set; }
        public decimal? Sum5 { get; set; }
        public decimal? Sum6 { get; set; }
        public decimal? Sum7 { get; set; }
        public decimal? Sum8 { get; set; }
        public decimal? Sum9 { get; set; }
        public decimal? Sum10 { get; set; }
        public decimal? Summ { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string VersionIdCode { get; set; }
        public string VersionIdName { get; set; }
        public int? ValueType { get; set; }
        public string ValueTypeCode { get; set; }
    }
}
