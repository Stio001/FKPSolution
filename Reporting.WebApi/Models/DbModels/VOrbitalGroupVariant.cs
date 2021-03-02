using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VOrbitalGroupVariant
    {
        public Guid Rid { get; set; }
        public Guid VersionId { get; set; }
        public string VersionIdCode { get; set; }
        public int Num { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateModify { get; set; }
    }
}
