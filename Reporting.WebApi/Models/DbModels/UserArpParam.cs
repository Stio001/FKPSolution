﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class UserArpParam
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public int? Num { get; set; }
        public string Name { get; set; }
        public int? DataType { get; set; }
        public string DataMask { get; set; }
        public int? LinkType { get; set; }
        public Guid? LinkSection { get; set; }
        public Guid? LinkField { get; set; }
        public string Label { get; set; }
        public string DefaultValueStr { get; set; }
        public DateTime? DefaultValueDate { get; set; }
        public bool? DefaultValueDateIsCurrent { get; set; }
        public decimal? DefaultValueNum { get; set; }
        public string ProcedureParam { get; set; }
        public bool? IsRid { get; set; }
        public bool? IsCanGetList { get; set; }
        public bool? IsOutput { get; set; }
        public int? NumberInt { get; set; }
        public int? NumberFr { get; set; }
        public int? NumberBit { get; set; }
        public int? StringLen { get; set; }
    }
}
