using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VVersionTaskResult
    {
        public Guid? ParentId { get; set; }
        public string TaskNum { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string TaskState { get; set; }
        public int StepNum { get; set; }
        public string UserFromIdCode { get; set; }
        public string RoleToIdCode { get; set; }
        public string UserToIdCode { get; set; }
        public string StepState { get; set; }
        public string ElementName { get; set; }
        public string ElementState { get; set; }
        public string StructurePath { get; set; }
    }
}
