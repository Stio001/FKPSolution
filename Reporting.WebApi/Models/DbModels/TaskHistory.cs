using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TaskHistory
    {
        public Guid Rid { get; set; }
        public Guid TaskId { get; set; }
        public Guid? ElementId { get; set; }
        public string UserName { get; set; }
        public DateTime StateDate { get; set; }
        public string Content { get; set; }
        public short? ActionType { get; set; }
    }
}
