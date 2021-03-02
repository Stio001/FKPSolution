using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class GroupParamParam
    {
        public Guid Rid { get; set; }
        public Guid GroupId { get; set; }
        public Guid ParamId { get; set; }
        public string Formula { get; set; }

        public virtual GroupParamGroup Group { get; set; }
        public virtual ParamParam Param { get; set; }
    }
}
