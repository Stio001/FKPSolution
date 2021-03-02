using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class GroupParamGroup
    {
        public GroupParamGroup()
        {
            GroupParamParams = new HashSet<GroupParamParam>();
            ParamParams = new HashSet<ParamParam>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Guid CatalogId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual ICollection<GroupParamParam> GroupParamParams { get; set; }
        public virtual ICollection<ParamParam> ParamParams { get; set; }
    }
}
