using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class WorkWork
    {
        public WorkWork()
        {
            InverseParent = new HashSet<WorkWork>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? TypeId { get; set; }
        public string Note { get; set; }
        public Guid? CategoryId { get; set; }
        public string ShortName { get; set; }
        public Guid? WorkCodeId { get; set; }
        public Guid? StageId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid VersionId { get; set; }
        public Guid? ParentId { get; set; }
        public int? ColorCondition { get; set; }
        public Guid EntryId { get; set; }
        public decimal? Rank { get; set; }
        public string RegNum { get; set; }
        public string ProgNum { get; set; }
        public Guid? SectionId { get; set; }
        public Guid? DictionaryWorkId { get; set; }
        public Guid? ProjectId { get; set; }
        public int? OrderNum { get; set; }

        public virtual DictionaryDictionary Category { get; set; }
        public virtual GlobalGlobalEntry Entry { get; set; }
        public virtual WorkWork Parent { get; set; }
        public virtual ProjectProject Project { get; set; }
        public virtual WorkSection Section { get; set; }
        public virtual WorkStage Stage { get; set; }
        public virtual DictionaryDictionary Type { get; set; }
        public virtual VersionVersion Version { get; set; }
        public virtual WorkCode WorkCode { get; set; }
        public virtual ICollection<WorkWork> InverseParent { get; set; }
    }
}
