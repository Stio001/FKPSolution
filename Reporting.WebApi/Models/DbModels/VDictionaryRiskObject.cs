﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryRiskObject
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string ShortName { get; set; }
        public int? WorkType { get; set; }
        public string WorkTypeCode { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? WorkCodeId { get; set; }
        public string WorkCodeIdCode { get; set; }
        public decimal? Rank { get; set; }
        public string RegNum { get; set; }
        public string ProgNum { get; set; }
        public Guid? SectionId { get; set; }
        public Guid? StageId { get; set; }
        public bool? UseInDoc { get; set; }
        public Guid? KindId { get; set; }
        public Guid VersionId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string ProjectIdCode { get; set; }
        public string PrintName { get; set; }
        public string VersionCode { get; set; }
        public string VersionName { get; set; }
    }
}
