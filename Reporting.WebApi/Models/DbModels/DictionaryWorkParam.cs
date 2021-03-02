using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryWorkParam
    {
        public Guid Rid { get; set; }
        public Guid ParentId { get; set; }
        public Guid VersionId { get; set; }
        public decimal? Rank { get; set; }
        public string ProgNum { get; set; }
        public bool? UseInDoc { get; set; }
        public bool? IsDone { get; set; }
        public decimal? BaseRank { get; set; }
        public decimal? StagePercent { get; set; }
        public decimal? StageValue { get; set; }
        public int? State { get; set; }
        public decimal? Priority { get; set; }
        public string PrintName { get; set; }

        public virtual DictionaryWork Parent { get; set; }
        public virtual VersionVersion Version { get; set; }
    }
}
