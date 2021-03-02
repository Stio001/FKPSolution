using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class StructureStructureGetWorkGanttTemp
    {
        public Guid Rid { get; set; }
        public Guid? AppointmentId { get; set; }
        public Guid? ResourceId { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public string TypeStructElement { get; set; }
        public string ShortName { get; set; }
        public string Color { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? Summ { get; set; }
        public decimal? StageSum { get; set; }
        public int? WorkType { get; set; }
        public string UserName { get; set; }
        public Guid? ProcessId { get; set; }
        public Guid? ElementId { get; set; }
        public Guid? VersionId { get; set; }
        public string FullName { get; set; }
        public int? PrgOrStg { get; set; }
        public Guid? EventTypeId { get; set; }
        public string EventTypeIdCode { get; set; }
        public Guid? ParentDictionaryWorkId { get; set; }
    }
}
