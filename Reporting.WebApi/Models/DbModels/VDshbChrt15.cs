﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDshbChrt15
    {
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string WorkCode { get; set; }
        public string WorkName { get; set; }
        public string WorkShortName { get; set; }
        public string ParamCode { get; set; }
        public string ParamShortName { get; set; }
        public string VersionCode { get; set; }
        public string VersionName { get; set; }
        public decimal? Value { get; set; }
    }
}
