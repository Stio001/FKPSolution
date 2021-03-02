using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class GroupWorkWork
    {
        public Guid Rid { get; set; }
        public Guid GroupId { get; set; }
        public Guid WorkId { get; set; }
        public string Formula { get; set; }

        public virtual GroupWorkGroup Group { get; set; }
        public virtual DictionaryWork Work { get; set; }
    }
}
