using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTaskResultValueLight
    {
        public Guid Rid { get; set; }
        public decimal? ProposedValue { get; set; }
        public DateTime? ProposedDateFrom { get; set; }
        public DateTime? ProposedDateTo { get; set; }
    }
}
