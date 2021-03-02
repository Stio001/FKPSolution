using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class PostPost
    {
        public PostPost()
        {
            AgentPeople = new HashSet<AgentPerson>();
            PostDuties = new HashSet<PostDuty>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Note { get; set; }
        public Guid CatalogId { get; set; }
        public string Num { get; set; }
        public Guid? DepartmentId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid? CategoryId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual DictionaryDictionary Category { get; set; }
        public virtual DepartmentDepartment Department { get; set; }
        public virtual ICollection<AgentPerson> AgentPeople { get; set; }
        public virtual ICollection<PostDuty> PostDuties { get; set; }
    }
}
