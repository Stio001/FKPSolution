﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VStructureElementEfficiency
    {
        public Guid? Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? TypeId { get; set; }
        public string TypeIdCode { get; set; }
        public int? WorkType { get; set; }
        public int ElementType { get; set; }
        public Guid? VersionId { get; set; }
        public string StructurePath { get; set; }
        public int? WorkCodeIdCode { get; set; }
        public int? ProjectIdCode { get; set; }
        public int? StageOrder { get; set; }
        public int MainType { get; set; }
    }
}
