﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VFinancialChartAutomaticKa
    {
        public string ProjectIdCode { get; set; }
        public Guid? ProjectId { get; set; }
        public decimal? SumValue { get; set; }
        public Guid VersionId { get; set; }
        public string WorkDirectionCode { get; set; }
    }
}
