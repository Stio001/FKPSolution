﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VProjectProject
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? Priority { get; set; }
        public int? TypeId { get; set; }
        public int? TypeIdCode { get; set; }
        public string TypeIdName { get; set; }
        public Guid? VersionId { get; set; }
        public string WorkDirectionCode { get; set; }
        public decimal? BaseRank { get; set; }
        public decimal? Priority2 { get; set; }
        public decimal? Priority3 { get; set; }
        public decimal? FinSum1 { get; set; }
        public decimal? FinSum2 { get; set; }
        public decimal? FinSum { get; set; }
        public decimal? AllowableSum { get; set; }
        public decimal? LaborCost { get; set; }
        public decimal? PercentSum { get; set; }
        public string ProjectUser { get; set; }
        public string EconomicEffectCode { get; set; }
        public decimal? RiskValueR { get; set; }
        public string TargetIndicatorCode { get; set; }
    }
}
