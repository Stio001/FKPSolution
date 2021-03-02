using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class WorkDocument
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid DocumentId { get; set; }

        public virtual ExternalDocument Document { get; set; }
    }
}
