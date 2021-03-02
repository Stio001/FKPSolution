using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemAlert
    {
        public Guid Rid { get; set; }
        public string Note { get; set; }
        public int? AlertType { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsActual { get; set; }
        public string UserName { get; set; }
        public int? WaitTimeSec { get; set; }
        public DateTime? ShowBefore { get; set; }
    }
}
