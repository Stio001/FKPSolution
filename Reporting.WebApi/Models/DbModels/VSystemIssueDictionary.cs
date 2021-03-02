using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemIssueDictionary
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? OrderPlace { get; set; }
        public Guid EntryId { get; set; }
        public string Description { get; set; }
    }
}
