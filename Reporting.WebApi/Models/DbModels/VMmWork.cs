using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VMmWork
    {
        public Guid Rid { get; set; }
        public Guid CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid StageId { get; set; }
        public int? RapidKoef { get; set; }
        public decimal? RankParam1 { get; set; }
        public decimal? RankParam2 { get; set; }
        public decimal? RankParam3 { get; set; }
        public decimal? RankParam4 { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string StageIdCode { get; set; }
        public string StageIdName { get; set; }
        public string RapidKoefName { get; set; }
        public decimal? RapidKoefValue { get; set; }
    }
}
