using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemLicense
    {
        public Guid Rid { get; set; }
        public byte[] FileData { get; set; }
        public string FileName { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Guid? OrganizationId { get; set; }
        public int? WorkPlaceCount { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
