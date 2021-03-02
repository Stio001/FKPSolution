using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class RiskPriority
    {
        public Guid Rid { get; set; }
        public Guid DictionaryWorkId { get; set; }
        public Guid VersionId { get; set; }
        public Guid PersonId { get; set; }
        public decimal? R11 { get; set; }
        public decimal? R12 { get; set; }
        public decimal? R13 { get; set; }
        public decimal? R21 { get; set; }
        public decimal? R22 { get; set; }
        public decimal? R23 { get; set; }
        public decimal? R31 { get; set; }
        public decimal? R32 { get; set; }
        public decimal? R33 { get; set; }

        public virtual VersionVersion Version { get; set; }
    }
}
