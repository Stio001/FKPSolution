using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDashBoardDashBoard
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public byte[] Graph { get; set; }
        public string FileName { get; set; }
        public int GraphType { get; set; }
    }
}
