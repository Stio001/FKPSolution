using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TaskStep
    {
        public TaskStep()
        {
            TaskResultValues = new HashSet<TaskResultValue>();
            TaskStepElements = new HashSet<TaskStepElement>();
        }

        public Guid Rid { get; set; }
        public Guid TaskId { get; set; }
        public int Num { get; set; }
        public string TaskText { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid UserFromId { get; set; }
        public Guid? RoleToId { get; set; }
        public Guid? UserToId { get; set; }
        public int State { get; set; }
        public string Answer { get; set; }
        public string Note { get; set; }
        public string UserName { get; set; }
        public DateTime? ExecDate { get; set; }
        public string DelayReason { get; set; }

        public virtual SystemRole RoleTo { get; set; }
        public virtual TaskTask Task { get; set; }
        public virtual SystemUser UserFrom { get; set; }
        public virtual SystemUser UserTo { get; set; }
        public virtual ICollection<TaskResultValue> TaskResultValues { get; set; }
        public virtual ICollection<TaskStepElement> TaskStepElements { get; set; }
    }
}
