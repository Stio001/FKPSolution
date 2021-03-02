using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class WorkRelation
    {
        public Guid Rid { get; set; }
        public int? LinkType { get; set; }
        public Guid? WorkInId { get; set; }
        public Guid? WorkOutId { get; set; }
    }
}
