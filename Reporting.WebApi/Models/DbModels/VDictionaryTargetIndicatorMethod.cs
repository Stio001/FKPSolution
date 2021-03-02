using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryTargetIndicatorMethod
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public Guid? VersionId { get; set; }
        public byte[] Method { get; set; }
    }
}
