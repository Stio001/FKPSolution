using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VUserGraphUnload
    {
        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public byte[] Graph { get; set; }
        public string ProcedureName { get; set; }
        public string Note { get; set; }
    }
}
