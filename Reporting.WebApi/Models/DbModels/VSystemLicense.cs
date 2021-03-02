using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemLicense
    {
        public Guid Rid { get; set; }
        public string FileName { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid? OrganizationId { get; set; }
        public string OrganizationIdCode { get; set; }
        public int? WorkPlaceCount { get; set; }
    }
}
