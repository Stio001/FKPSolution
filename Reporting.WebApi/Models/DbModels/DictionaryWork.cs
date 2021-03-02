using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryWork
    {
        public DictionaryWork()
        {
            DictionaryWorkParams = new HashSet<DictionaryWorkParam>();
            GroupWorkWorks = new HashSet<GroupWorkWork>();
            InverseParent = new HashSet<DictionaryWork>();
            StageStages = new HashSet<StageStage>();
        }

        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string ShortName { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? WorkCodeId { get; set; }
        public decimal? Rank { get; set; }
        public string RegNum { get; set; }
        public string ProgNum { get; set; }
        public Guid? SectionId { get; set; }
        public Guid? StageId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? ProjectId { get; set; }
        public bool? UseInDoc { get; set; }
        public Guid? KindId { get; set; }
        public int? WorkType { get; set; }
        public int? FinDirection { get; set; }
        public decimal? StagePercent { get; set; }
        public decimal? StageValue { get; set; }
        public int? StageOrder { get; set; }
        public string PrintName { get; set; }
        public Guid? Gostid { get; set; }
        public Guid? StageTypeId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual DictionaryDictionary Category { get; set; }
        public virtual DictionaryDictionary Gost { get; set; }
        public virtual DictionaryDictionary Kind { get; set; }
        public virtual DictionaryWork Parent { get; set; }
        public virtual ProjectProject Project { get; set; }
        public virtual WorkSection Section { get; set; }
        public virtual WorkStage Stage { get; set; }
        public virtual DictionaryStageType StageType { get; set; }
        public virtual WorkCode WorkCode { get; set; }
        public virtual ICollection<DictionaryWorkParam> DictionaryWorkParams { get; set; }
        public virtual ICollection<GroupWorkWork> GroupWorkWorks { get; set; }
        public virtual ICollection<DictionaryWork> InverseParent { get; set; }
        public virtual ICollection<StageStage> StageStages { get; set; }
    }
}
