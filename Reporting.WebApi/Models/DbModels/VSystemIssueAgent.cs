using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemIssueAgent
    {
        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Inn { get; set; }
        public string Cpp { get; set; }
        public string Okpo { get; set; }
        public string Ogrn { get; set; }
        public Guid CatalogId { get; set; }
        public string Note { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int AgentType { get; set; }
        public DateTime? DateR { get; set; }
        public string Address { get; set; }
        public string AddName { get; set; }
        public Guid? AgentCategory { get; set; }
    }
}
