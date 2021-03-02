using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class MmWorkGroup
    {
        public MmWorkGroup()
        {
            MmWorkGroupPeople = new HashSet<MmWorkGroupPerson>();
        }

        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Note { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual ICollection<MmWorkGroupPerson> MmWorkGroupPeople { get; set; }
    }
}
