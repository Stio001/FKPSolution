using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSysPriorityCriterionRankValue
    {
        public int Code { get; set; }
        public string SValue { get; set; }
        public decimal NValue { get; set; }
        public decimal InvValue { get; set; }
        public string Description { get; set; }
    }
}
