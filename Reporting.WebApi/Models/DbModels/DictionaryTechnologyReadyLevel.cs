using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryTechnologyReadyLevel
    {
        public DictionaryTechnologyReadyLevel()
        {
            DictionaryStageTypes = new HashSet<DictionaryStageType>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string RealizeForm { get; set; }
        public string Note { get; set; }

        public virtual ICollection<DictionaryStageType> DictionaryStageTypes { get; set; }
    }
}
