using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VGroupParamParam
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid ParamId { get; set; }
        public string Formula { get; set; }
        public string ParamIdCode { get; set; }
        public string ParamIdName { get; set; }
    }
}
