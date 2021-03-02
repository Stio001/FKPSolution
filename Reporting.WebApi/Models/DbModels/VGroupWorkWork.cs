using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VGroupWorkWork
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid WorkId { get; set; }
        public string Formula { get; set; }
        public string WorkCode { get; set; }
        public string WorkIdCode { get; set; }
    }
}
