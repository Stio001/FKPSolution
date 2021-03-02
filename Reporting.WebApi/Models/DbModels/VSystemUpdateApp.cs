using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemUpdateApp
    {
        public Guid Rid { get; set; }
        public byte[] FileData { get; set; }
        public string FileName { get; set; }
        public string RelPath { get; set; }
        public string FileVersion { get; set; }
        public string HashSum { get; set; }
    }
}
