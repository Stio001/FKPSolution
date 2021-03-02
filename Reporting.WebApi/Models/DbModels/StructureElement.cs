using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class StructureElement
    {
        public StructureElement()
        {
            InverseParent = new HashSet<StructureElement>();
        }

        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Guid? TypeId { get; set; }

        public virtual StructureElement Parent { get; set; }
        public virtual DictionaryDictionary Type { get; set; }
        public virtual ICollection<StructureElement> InverseParent { get; set; }
    }
}
