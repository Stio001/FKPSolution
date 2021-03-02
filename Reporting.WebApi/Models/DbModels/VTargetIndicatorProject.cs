using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTargetIndicatorProject
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid ProjectId { get; set; }
        public decimal? Koeff { get; set; }
        public string ProjectNum { get; set; }
        public string ProjectIdCode { get; set; }
        public string ProjectIdName { get; set; }
    }
}
