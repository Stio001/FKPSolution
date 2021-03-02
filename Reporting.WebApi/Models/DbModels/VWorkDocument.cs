using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VWorkDocument
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid DocumentId { get; set; }
        public string DocumentIdDocNum { get; set; }
        public Guid? DocumentIdDocTypeId { get; set; }
        public DateTime? DocumentIdDocDate { get; set; }
        public string DocumentIdFileName { get; set; }
        public string DocTypeCode { get; set; }
    }
}
