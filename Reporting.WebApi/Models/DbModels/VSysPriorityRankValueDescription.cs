using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSysPriorityRankValueDescription
    {
        public int Code { get; set; }
        public string SValue { get; set; }
        public decimal NValue { get; set; }
    }
}
