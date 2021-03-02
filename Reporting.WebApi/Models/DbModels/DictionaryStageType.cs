using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryStageType
    {
        public DictionaryStageType()
        {
            DictionaryWorks = new HashSet<DictionaryWork>();
            StageStages = new HashSet<StageStage>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? WorkKindId { get; set; }
        public Guid? Gostid { get; set; }
        public Guid? TechnologyReadyLevelId { get; set; }
        public int? OrderNum { get; set; }

        public virtual DictionaryDictionary Gost { get; set; }
        public virtual DictionaryTechnologyReadyLevel TechnologyReadyLevel { get; set; }
        public virtual DictionaryDictionary WorkKind { get; set; }
        public virtual ICollection<DictionaryWork> DictionaryWorks { get; set; }
        public virtual ICollection<StageStage> StageStages { get; set; }
    }
}
