using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VRiskEvent
    {
        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public Guid VersionId { get; set; }
        public Guid DictionaryRiskId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string BaseEvent { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string VersionIdCode { get; set; }
        public string VersionIdName { get; set; }
        public string DictionaryRiskIdCode { get; set; }
        public string DictionaryRiskIdName { get; set; }
        public string DictionaryRiskTypeCode { get; set; }
        public string DictionaryRiskTypeName { get; set; }
    }
}
