using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VRiskEventValueDetail
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid DictionaryRiskId { get; set; }
        public string Note { get; set; }
        public string DictionaryRiskCode { get; set; }
        public string DictionaryRiskName { get; set; }
        public string DictionaryRiskTypeIdCode { get; set; }
    }
}
