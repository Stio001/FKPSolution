using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryWorkEventFin
    {
        public Guid Rid { get; set; }
        public Guid FinId { get; set; }
        public Guid EventId { get; set; }
        public decimal? NSum { get; set; }

        public virtual DictionaryWorkEvent Event { get; set; }
        public virtual DictionaryWorkEvent Fin { get; set; }
    }
}
