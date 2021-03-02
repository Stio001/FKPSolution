using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryWorkEventUndo
    {
        public Guid Rid { get; set; }
        public Guid Dwid { get; set; }
        public Guid Dweid { get; set; }
        public Guid VersionId { get; set; }
        public string Action { get; set; }
        public int? ChangedYear { get; set; }
        public decimal? ValueBefore { get; set; }
        public decimal? ValueAfter { get; set; }
        public bool? IsBudget { get; set; }
        public DateTime InsDate { get; set; }
    }
}
