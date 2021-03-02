using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class UserReportSection
    {
        public Guid Rid { get; set; }
        public Guid? SectionId { get; set; }
        public Guid? ReportId { get; set; }

        public virtual GlobalGlobalEntry Section { get; set; }
    }
}
