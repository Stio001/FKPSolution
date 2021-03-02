using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VStructureStructureGetWorkGanttSession
    {
        public Guid Rid { get; set; }
        public string OwnerUserName { get; set; }
        public DateTime DateBegin { get; set; }
        public Guid ElementId { get; set; }
        public string PersonIdCode { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string WorkTypeCode { get; set; }
        public Guid? VersionId { get; set; }
    }
}
