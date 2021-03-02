using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VRiskEventProbabilityValue
    {
        public Guid Rid { get; set; }
        public int Num { get; set; }
        public decimal Value { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
