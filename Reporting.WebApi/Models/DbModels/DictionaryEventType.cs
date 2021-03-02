using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryEventType
    {
        public DictionaryEventType()
        {
            DictionaryWorkEvents = new HashSet<DictionaryWorkEvent>();
            InverseParent = new HashSet<DictionaryEventType>();
        }

        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual DictionaryEventType Parent { get; set; }
        public virtual ICollection<DictionaryWorkEvent> DictionaryWorkEvents { get; set; }
        public virtual ICollection<DictionaryEventType> InverseParent { get; set; }
    }
}
