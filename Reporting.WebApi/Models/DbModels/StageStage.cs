using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class StageStage
    {
        public Guid Rid { get; set; }
        public Guid DictionaryWorkId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid VersionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int StageOrder { get; set; }
        public int WorkType { get; set; }
        public Guid? Gostid { get; set; }
        public Guid? StageTypeId { get; set; }
        public decimal? Priority { get; set; }
        public Guid? KindId { get; set; }
        public Guid? WorkCategoryId { get; set; }
        public decimal? StagePercent { get; set; }
        public decimal? StageValue { get; set; }
        public string Note { get; set; }

        public virtual DictionaryWork DictionaryWork { get; set; }
        public virtual DictionaryDictionary Gost { get; set; }
        public virtual DictionaryDictionary Kind { get; set; }
        public virtual DictionaryStageType StageType { get; set; }
        public virtual VersionVersion Version { get; set; }
        public virtual DictionaryDictionary WorkCategory { get; set; }
    }
}
