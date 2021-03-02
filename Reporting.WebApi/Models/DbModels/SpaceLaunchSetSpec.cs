using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SpaceLaunchSetSpec
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid KaRid { get; set; }

        public virtual DictionaryTechnic KaR { get; set; }
        public virtual SpaceLaunchSet Parent { get; set; }
    }
}
