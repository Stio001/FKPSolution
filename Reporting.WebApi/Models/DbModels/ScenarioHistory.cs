using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ScenarioHistory
    {
        public Guid Rid { get; set; }
        public Guid? TaskId { get; set; }
        public string UserName { get; set; }
        public DateTime? ExecDate { get; set; }
        public int? StateId { get; set; }
        public Guid ScenarioStageId { get; set; }

        public virtual ScenarioStage ScenarioStage { get; set; }
    }
}
