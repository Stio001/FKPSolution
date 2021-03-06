﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VUserGraphGraph
    {
        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string ProcedureName { get; set; }
        public int GraphTypeId { get; set; }
        public string GraphTypeIdName { get; set; }
        public string Note { get; set; }
    }
}
