using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkEventTechnic
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid TechnicId { get; set; }
        public string Note { get; set; }
        public string TechnicIdCode { get; set; }
    }
}
