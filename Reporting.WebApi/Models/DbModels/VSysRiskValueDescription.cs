using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSysRiskValueDescription
    {
        public int Code { get; set; }
        public decimal Value { get; set; }
        public string Name { get; set; }
    }
}
