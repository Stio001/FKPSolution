using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VVersionVersion
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Note { get; set; }
        public DateTime? AcceptDate { get; set; }
        public DateTime? StateDate { get; set; }
        public string Num { get; set; }
        public int StateId { get; set; }
        public string StateIdCode { get; set; }
        public Guid? TypeId { get; set; }
        public string TypeCode { get; set; }
        public string TypeIdCode { get; set; }
        public string LookCode { get; set; }
        public string LookName { get; set; }
        public int? IsRemoved { get; set; }
        public Guid? VersionFromId { get; set; }
        public string VersionFromCode { get; set; }
        public string CreateInfo { get; set; }
        public bool? UseInGraph { get; set; }
        public string ValidDocNum { get; set; }
        public DateTime? ValidDocDate { get; set; }
    }
}
