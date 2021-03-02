using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkStage
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid VersionId { get; set; }
        public int? WorkType { get; set; }
    }
}
