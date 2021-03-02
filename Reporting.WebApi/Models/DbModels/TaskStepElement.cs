using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TaskStepElement
    {
        public Guid Rid { get; set; }
        public Guid StepId { get; set; }
        public Guid TaskElementId { get; set; }

        public virtual TaskStep Step { get; set; }
        public virtual TaskElement TaskElement { get; set; }
    }
}
