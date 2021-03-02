using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class GroupWorkGroup
    {
        public GroupWorkGroup()
        {
            GroupWorkWorks = new HashSet<GroupWorkWork>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Guid CatalogId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual ICollection<GroupWorkWork> GroupWorkWorks { get; set; }
    }
}
