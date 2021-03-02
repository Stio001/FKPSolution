using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TaskTask
    {
        public TaskTask()
        {
            TaskElements = new HashSet<TaskElement>();
            TaskSteps = new HashSet<TaskStep>();
        }

        public Guid Rid { get; set; }
        public Guid? VersionId { get; set; }
        public string Num { get; set; }
        public string RegNum { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? TaskTypeId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid? StageId { get; set; }
        public int State { get; set; }
        public string TaskText { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime? ExecDate { get; set; }
        public string DelayReason { get; set; }
        public Guid? SeniorWorks { get; set; }

        public virtual AgentAgent Customer { get; set; }
        public virtual AgentAgent SeniorWorksNavigation { get; set; }
        public virtual WorkStage Stage { get; set; }
        public virtual DictionaryDictionary TaskType { get; set; }
        public virtual VersionVersion Version { get; set; }
        public virtual ICollection<TaskElement> TaskElements { get; set; }
        public virtual ICollection<TaskStep> TaskSteps { get; set; }
    }
}
