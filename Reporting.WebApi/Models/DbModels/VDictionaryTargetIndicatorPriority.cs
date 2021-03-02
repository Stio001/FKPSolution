using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryTargetIndicatorPriority
    {
        public Guid Rid { get; set; }
        public Guid? VersionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? ProjectId { get; set; }
        public decimal? ProjectKoeff { get; set; }
        public string ProjectNum { get; set; }
        public string ProjectCode { get; set; }
        public Guid? WorkDirectionId { get; set; }
        public string WorkDirectionNumb { get; set; }
        public string WorkDirectionCode { get; set; }
        public string WorkDirectionName { get; set; }
        public decimal? WorkDirectionPriority { get; set; }
        public decimal? IndicatorPriority { get; set; }
    }
}
