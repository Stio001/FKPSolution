using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class FinanceWorkPlaceDataUndo
    {
        public Guid Rid { get; set; }
        public int Step { get; set; }
        public Guid ValueId { get; set; }
        public decimal? NValue { get; set; }
        public Guid? ProcessId { get; set; }
        public string UserId { get; set; }
        public DateTime? SetDate { get; set; }
        public int? OperKind { get; set; }
    }
}
