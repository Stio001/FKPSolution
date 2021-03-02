using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VPostPost
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Note { get; set; }
        public Guid CatalogId { get; set; }
        public string Num { get; set; }
        public Guid DepartmentId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid? CategoryId { get; set; }
        public string CategoryIdCode { get; set; }
        public string CategoryIdName { get; set; }
        public string DepartmentIdCode { get; set; }
        public string DepartmentCode { get; set; }
    }
}
