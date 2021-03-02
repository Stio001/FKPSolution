using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryTechnicKaLight
    {
        public Guid Rid { get; set; }
        public string ShortName { get; set; }
        public Guid? TypeId { get; set; }
        public Guid VersionId { get; set; }
        public string ExtName { get; set; }
    }
}
