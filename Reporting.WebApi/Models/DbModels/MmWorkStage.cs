using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class MmWorkStage
    {
        public MmWorkStage()
        {
            MmWorkPersonContributions = new HashSet<MmWorkPersonContribution>();
            MmWorks = new HashSet<MmWork>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Note { get; set; }

        public virtual ICollection<MmWorkPersonContribution> MmWorkPersonContributions { get; set; }
        public virtual ICollection<MmWork> MmWorks { get; set; }
    }
}
