using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryTargetIndicator
    {
        public DictionaryTargetIndicator()
        {
            TargetIndicatorProjects = new HashSet<TargetIndicatorProject>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal? Priority { get; set; }
        public byte[] Dashboard { get; set; }
        public Guid? MeasureId { get; set; }
        public string SFormat { get; set; }
        public Guid? VersionId { get; set; }
        public short? TrendType { get; set; }
        public byte[] Method { get; set; }
        public Guid? ParentId { get; set; }
        public int? ElementType { get; set; }
        public string ProcedureName { get; set; }
        public bool? IsPrint { get; set; }
        public bool? ManualEdit { get; set; }
        public bool? IsCalcEfficiency { get; set; }
        public string ShortName { get; set; }
        public bool? IsUpdate { get; set; }

        public virtual VersionVersion Version { get; set; }
        public virtual ICollection<TargetIndicatorProject> TargetIndicatorProjects { get; set; }
    }
}
