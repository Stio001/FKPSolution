using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TaskElement
    {
        public TaskElement()
        {
            TaskResultValues = new HashSet<TaskResultValue>();
            TaskStepElements = new HashSet<TaskStepElement>();
        }

        public Guid Rid { get; set; }
        public Guid TaskId { get; set; }
        public Guid ElementId { get; set; }
        public string ElementValue { get; set; }
        public int? ElementValueDataType { get; set; }
        public int ChangeType { get; set; }
        public int State { get; set; }
        public string TaskText { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string UserName { get; set; }

        public virtual TaskTask Task { get; set; }
        public virtual ICollection<TaskResultValue> TaskResultValues { get; set; }
        public virtual ICollection<TaskStepElement> TaskStepElements { get; set; }
    }
}
