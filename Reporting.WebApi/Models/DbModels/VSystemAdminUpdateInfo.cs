using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemAdminUpdateInfo
    {
        public Guid Rid { get; set; }
        public string UserName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateVersion { get; set; }
        public int? UpdateState { get; set; }
        public string Note { get; set; }
        public string UpdatePackageName { get; set; }
    }
}
