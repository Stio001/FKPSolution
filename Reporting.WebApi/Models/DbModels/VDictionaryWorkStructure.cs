using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkStructure
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? WorkType { get; set; }
        public string WorkTypeCode { get; set; }
        public string WorkCodeIdCode { get; set; }
        public string ProgNum { get; set; }
        public Guid VersionId { get; set; }
        public string ProjectIdCode { get; set; }
        public int? StageOrder { get; set; }
    }
}
