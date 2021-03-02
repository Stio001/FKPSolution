using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSpaceLaunchSet
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? RnRid { get; set; }
        public Guid? RbRid { get; set; }
        public Guid? ObRid { get; set; }
        public string RbRidCode { get; set; }
        public string RbRidName { get; set; }
        public string ObRidCode { get; set; }
        public string ObRidName { get; set; }
        public Guid? RbTypeId { get; set; }
        public string RbTypeIdCode { get; set; }
        public string RbTypeIdName { get; set; }
        public string ObTypeIdCode { get; set; }
        public Guid? VersionId { get; set; }
        public string VersionCode { get; set; }
        public string VersionIdCode { get; set; }
        public Guid? CatalogId { get; set; }
        public Guid? SlRid { get; set; }
        public string SlRidCode { get; set; }
        public string SlRidName { get; set; }
        public string ObStateIdCode { get; set; }
        public string RbStateIdCode { get; set; }
        public Guid? RnTypeId { get; set; }
        public string RnStateIdCode { get; set; }
        public string RnRidCode { get; set; }
        public string RnRidName { get; set; }
        public string ClassRnCode { get; set; }
        public string RnTypeIdCode { get; set; }
        public string RnTypeIdName { get; set; }
        public DateTime? StorageExpirationDateRn { get; set; }
        public DateTime? StorageExpirationDateRb { get; set; }
        public DateTime? StorageExpirationDateOb { get; set; }
        public DateTime? PlanDateFrom { get; set; }
        public DateTime? MinimumDate { get; set; }
        public string Note { get; set; }
    }
}
