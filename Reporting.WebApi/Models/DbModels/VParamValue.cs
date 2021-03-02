using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VParamValue
    {
        public Guid Rid { get; set; }
        public Guid? ParamId { get; set; }
        public Guid? VersionId { get; set; }
        public decimal? ValueN1 { get; set; }
        public decimal? ValueN2 { get; set; }
        public string ValueStr { get; set; }
        public DateTime? ValueD1 { get; set; }
        public DateTime? ValueD2 { get; set; }
        public string Note { get; set; }
        public Guid? DictionaryValueId { get; set; }
        public int? LinkNum { get; set; }
        public string LinkText { get; set; }
        public string GeneralStrValue { get; set; }
    }
}
