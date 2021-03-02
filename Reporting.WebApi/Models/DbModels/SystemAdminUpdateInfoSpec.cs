using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemAdminUpdateInfoSpec
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string FileName { get; set; }
        public int State { get; set; }
        public string OldObjectScript { get; set; }

        public virtual SystemAdminUpdateInfo Parent { get; set; }
    }
}
