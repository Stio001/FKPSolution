using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TechnicTypeParam
    {
        public Guid Rid { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public int? SortNum { get; set; }
        public Guid ParentId { get; set; }
        public Guid ParamId { get; set; }
        public Guid? VersionId { get; set; }

        public virtual ParamParam Param { get; set; }
        public virtual TechnicType Parent { get; set; }
        public virtual VersionVersion Version { get; set; }
    }
}
