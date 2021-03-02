using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryStageType
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? WorkKindId { get; set; }
        public string WorkKindIdCode { get; set; }
        public string WorkKindIdName { get; set; }
        public Guid? Gostid { get; set; }
        public string GostidCode { get; set; }
        public Guid? TechnologyReadyLevelId { get; set; }
        public string TechnologyReadyLevelIdCode { get; set; }
        public string TechnologyReadyLevelIdName { get; set; }
        public int? OrderNum { get; set; }
    }
}
