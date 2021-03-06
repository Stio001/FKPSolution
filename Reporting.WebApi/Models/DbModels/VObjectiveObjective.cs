﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VObjectiveObjective
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int? Priority { get; set; }
        public DateTime? DateFrom { get; set; }
        public Guid? VersionId { get; set; }
    }
}
