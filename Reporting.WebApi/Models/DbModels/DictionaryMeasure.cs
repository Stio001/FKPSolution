using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class DictionaryMeasure
    {
        public DictionaryMeasure()
        {
            DictionaryWorkEvents = new HashSet<DictionaryWorkEvent>();
            ParamParams = new HashSet<ParamParam>();
        }

        public Guid Rid { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string NativCode { get; set; }
        public string UniCode { get; set; }
        public string ShortName { get; set; }
        public Guid CatalogId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual ICollection<DictionaryWorkEvent> DictionaryWorkEvents { get; set; }
        public virtual ICollection<ParamParam> ParamParams { get; set; }
    }
}
