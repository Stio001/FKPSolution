using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTechnicStatus
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid VersionId { get; set; }
        public short State { get; set; }
        public DateTime? StateDate { get; set; }
        public Guid EntryId { get; set; }
        public int? GroupNumber { get; set; }
        public string DocumentNote { get; set; }
        public string StateCode { get; set; }
    }
}
