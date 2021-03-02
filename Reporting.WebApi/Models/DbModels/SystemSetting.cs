using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemSetting
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? NValue { get; set; }
        public string SValue { get; set; }
        public Guid? GValue { get; set; }
        public bool? BValue { get; set; }
        public DateTime? DValue { get; set; }
        public Guid? LinkSection { get; set; }
        public Guid? LinkAttr { get; set; }
        public int? NType { get; set; }
        public bool? IsGlobal { get; set; }
        public string UserName { get; set; }
    }
}
