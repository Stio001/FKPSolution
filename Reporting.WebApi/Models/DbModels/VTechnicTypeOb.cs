using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VTechnicTypeOb
    {
        public Guid Rid { get; set; }
        public Guid EntryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public Guid VersionId { get; set; }
    }
}
