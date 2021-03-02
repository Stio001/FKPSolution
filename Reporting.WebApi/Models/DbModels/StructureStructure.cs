using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class StructureStructure
    {
        public StructureStructure()
        {
            InverseParent = new HashSet<StructureStructure>();
            StructureAgentGroups = new HashSet<StructureAgentGroup>();
        }

        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? ElementId { get; set; }
        public Guid? WorkId { get; set; }
        public Guid? VersionId { get; set; }
        public short? ElementType { get; set; }
        public decimal? Priority { get; set; }

        public virtual StructureStructure Parent { get; set; }
        public virtual VersionVersion Version { get; set; }
        public virtual ICollection<StructureStructure> InverseParent { get; set; }
        public virtual ICollection<StructureAgentGroup> StructureAgentGroups { get; set; }
    }
}
