using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class WorkStage
    {
        public WorkStage()
        {
            DictionaryWorks = new HashSet<DictionaryWork>();
            TaskTasks = new HashSet<TaskTask>();
            WorkWorks = new HashSet<WorkWork>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Note { get; set; }
        public Guid CatalogId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual ICollection<DictionaryWork> DictionaryWorks { get; set; }
        public virtual ICollection<TaskTask> TaskTasks { get; set; }
        public virtual ICollection<WorkWork> WorkWorks { get; set; }
    }
}
