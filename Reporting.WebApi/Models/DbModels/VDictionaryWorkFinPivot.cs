using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryWorkFinPivot
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public int? WorkType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid VersionId { get; set; }
        public decimal? _2015 { get; set; }
        public decimal? _2016 { get; set; }
        public decimal? _2017 { get; set; }
        public decimal? _2018 { get; set; }
        public decimal? _2019 { get; set; }
        public decimal? _2020 { get; set; }
        public decimal? _2021 { get; set; }
        public decimal? _2022 { get; set; }
        public decimal? _2023 { get; set; }
        public decimal? _2024 { get; set; }
        public decimal? _2025 { get; set; }
        public decimal? AllSumm { get; set; }
    }
}
