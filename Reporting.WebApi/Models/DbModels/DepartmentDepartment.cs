using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DepartmentDepartment
    {
        public DepartmentDepartment()
        {
            AgentPeople = new HashSet<AgentPerson>();
            InverseParent = new HashSet<DepartmentDepartment>();
            PostPosts = new HashSet<PostPost>();
        }

        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string ShortName { get; set; }
        public string Num { get; set; }
        public Guid? CategoryId { get; set; }

        public virtual DictionaryDictionary Category { get; set; }
        public virtual DepartmentDepartment Parent { get; set; }
        public virtual ICollection<AgentPerson> AgentPeople { get; set; }
        public virtual ICollection<DepartmentDepartment> InverseParent { get; set; }
        public virtual ICollection<PostPost> PostPosts { get; set; }
    }
}
