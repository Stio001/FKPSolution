using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class RiskEventProbabilityValue
    {
        public Guid Rid { get; set; }
        public int Num { get; set; }
        public decimal Value { get; set; }
        public string Name { get; set; }
    }
}
