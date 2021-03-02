using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class PurposePurpose
    {
        public PurposePurpose()
        {
            InverseParent = new HashSet<PurposePurpose>();
        }

        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Guid VersionId { get; set; }

        public virtual PurposePurpose Parent { get; set; }
        public virtual VersionVersion Version { get; set; }
        public virtual ICollection<PurposePurpose> InverseParent { get; set; }
    }
}
