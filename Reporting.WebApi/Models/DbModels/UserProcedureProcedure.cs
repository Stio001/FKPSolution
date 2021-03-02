using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class UserProcedureProcedure
    {
        public UserProcedureProcedure()
        {
            ParamParams = new HashSet<ParamParam>();
        }

        public Guid Rid { get; set; }
        public string Note { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ProcedureName { get; set; }
        public Guid CatalogId { get; set; }
        public int? PType { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual ICollection<ParamParam> ParamParams { get; set; }
    }
}
