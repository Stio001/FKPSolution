using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryPriorityCriterionList
    {
        public Guid Rid { get; set; }
        public Guid CategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsAutoCalc { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string CategoryIdCode { get; set; }
        public string CategoryCode { get; set; }
        public bool? IsCalculated { get; set; }
    }
}
