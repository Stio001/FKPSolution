using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryTechnicAnalog
    {
        public Guid Rid { get; set; }
        public Guid TechnicId { get; set; }
        public Guid AnalogId { get; set; }

        public virtual DictionaryTechnic Analog { get; set; }
        public virtual DictionaryTechnic Technic { get; set; }
    }
}
