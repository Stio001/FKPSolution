using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class StructureStructureGetWorkGanttSession
    {
        public Guid Rid { get; set; }
        public string OwnerUserName { get; set; }
        public DateTime DateBegin { get; set; }
        public Guid ElementId { get; set; }
        public Guid? VersionId { get; set; }
    }
}
