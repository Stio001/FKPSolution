using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class UserUser
    {
        public Guid Rid { get; set; }
        public string Name { get; set; }
        public Guid CatalogId { get; set; }
        public string UserName { get; set; }
        public string Note { get; set; }
        public Guid PersonId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual AgentPerson Person { get; set; }
    }
}
