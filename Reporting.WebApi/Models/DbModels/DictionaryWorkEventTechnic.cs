using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryWorkEventTechnic
    {
        public Guid Rid { get; set; }
        public Guid EventId { get; set; }
        public Guid TechnicId { get; set; }
        public string Note { get; set; }

        public virtual DictionaryWorkEvent Event { get; set; }
        public virtual DictionaryTechnic Technic { get; set; }
    }
}
