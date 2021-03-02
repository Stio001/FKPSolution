using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ParamValueResult
    {
        public Guid Rid { get; set; }
        public Guid ResultValueId { get; set; }
        public decimal? VariantValue1 { get; set; }
        public decimal? VariantValue2 { get; set; }
        public decimal? VariantValue3 { get; set; }
        public DateTime? VariantDateFrom1 { get; set; }
        public DateTime? VariantDateFrom2 { get; set; }
        public DateTime? VariantDateFrom3 { get; set; }
        public DateTime? VariantDateTo1 { get; set; }
        public DateTime? VariantDateTo2 { get; set; }
        public DateTime? VariantDateTo3 { get; set; }
        public Guid? VariantDic1 { get; set; }
        public Guid? VariantDic2 { get; set; }
        public Guid? VariantDic3 { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public int? Change { get; set; }

        public virtual DictionaryWorkEvent ResultValue { get; set; }
    }
}
