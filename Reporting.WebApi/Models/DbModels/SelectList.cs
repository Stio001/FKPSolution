using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SelectList
    {
        public Guid Rid { get; set; }
        public Guid DocId { get; set; }
        public string Entry { get; set; }
        public Guid ProcessId { get; set; }
        public string UserName { get; set; }
    }
}
