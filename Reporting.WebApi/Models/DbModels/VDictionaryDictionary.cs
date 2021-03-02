using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VDictionaryDictionary
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid EntryId { get; set; }
        public string EntrySystemName { get; set; }
        public bool? IsSystem { get; set; }
    }
}
