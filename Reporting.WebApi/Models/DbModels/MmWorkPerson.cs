using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class MmWorkPerson
    {
        public MmWorkPerson()
        {
            MmWorkPersonParams = new HashSet<MmWorkPersonParam>();
        }

        public Guid Rid { get; set; }
        public Guid WorkId { get; set; }
        public Guid PersonId { get; set; }
        public string Note { get; set; }

        public virtual AgentPerson Person { get; set; }
        public virtual MmWork Work { get; set; }
        public virtual ICollection<MmWorkPersonParam> MmWorkPersonParams { get; set; }
    }
}
