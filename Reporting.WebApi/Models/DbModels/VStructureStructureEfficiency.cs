using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VStructureStructureEfficiency
    {
        public Guid Rid { get; set; }
        public short? ElementType { get; set; }
        public Guid? ElementId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? VersionId { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TypeIdCode { get; set; }
        public Guid? WorkType { get; set; }
        public string WorkTypeCode { get; set; }
        public string CipCode { get; set; }
        public string DirectionCode { get; set; }
        public DateTime? CalcDate { get; set; }
        public decimal? Y2016 { get; set; }
        public decimal? Y2017 { get; set; }
        public decimal? Y2018 { get; set; }
        public decimal? Y2019 { get; set; }
        public decimal? Y2020 { get; set; }
        public decimal? Y2021 { get; set; }
        public decimal? Y2022 { get; set; }
        public decimal? Y2023 { get; set; }
        public decimal? Y2024 { get; set; }
        public decimal? Y2025 { get; set; }
    }
}
