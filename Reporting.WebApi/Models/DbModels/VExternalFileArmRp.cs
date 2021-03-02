using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VExternalFileArmRp
    {
        public Guid Rid { get; set; }
        public byte[] Fdata { get; set; }
        public string Description { get; set; }
        public DateTime? InDate { get; set; }
        public int? DocNum { get; set; }
        public string DocPref { get; set; }
    }
}
