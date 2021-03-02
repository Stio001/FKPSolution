using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TechnicTypeAnalog
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid AnalogId { get; set; }

        public virtual TechnicType Analog { get; set; }
        public virtual TechnicType Parent { get; set; }
    }
}
