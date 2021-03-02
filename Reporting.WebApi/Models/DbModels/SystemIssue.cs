using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class SystemIssue
    {
        public SystemIssue()
        {
            SystemIssueHistories = new HashSet<SystemIssueHistory>();
        }

        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public int Num { get; set; }
        public string Issue { get; set; }
        public int? TypeId { get; set; }
        public int PriorityId { get; set; }
        public string UserName { get; set; }
        public Guid PersonId { get; set; }
        public Guid? SectionId { get; set; }
        public Guid? ErrorId { get; set; }
        public string Executor { get; set; }
        public string Note { get; set; }
        public DateTime? DateNotifyExecutor { get; set; }
        public DateTime? PlannedPeriod { get; set; }
        public DateTime? FactDateExecution { get; set; }
        public DateTime? FactDateAccept { get; set; }
        public string LinkDocs { get; set; }
        public bool? OperatorAccept { get; set; }
        public byte[] Screenshot { get; set; }
        public string ExternalNumber { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual SystemErrorLog Error { get; set; }
        public virtual AgentPerson Person { get; set; }
        public virtual GlobalGlobalEntry Section { get; set; }
        public virtual ICollection<SystemIssueHistory> SystemIssueHistories { get; set; }
    }
}
