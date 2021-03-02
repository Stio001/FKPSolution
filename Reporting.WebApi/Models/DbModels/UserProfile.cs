using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class UserProfile
    {
        public Guid Rid { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public string UserName { get; set; }
        public string FileVersion { get; set; }
        public DateTime? LastOperation { get; set; }
    }
}
