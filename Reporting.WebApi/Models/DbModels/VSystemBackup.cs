using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemBackup
    {
        public Guid Rid { get; set; }
        public DateTime Date { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
    }
}
