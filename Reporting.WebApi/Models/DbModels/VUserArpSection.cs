using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VUserArpSection
    {
        public Guid Rid { get; set; }
        public Guid? ReportId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? SectionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string SArpname { get; set; }
        public int? SArptype { get; set; }
        public int NArptype { get; set; }
        public int? PType { get; set; }
    }
}
