using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemIssueAgentPerson
    {
        public Guid Rid { get; set; }
        public string TabNum { get; set; }
        public string Note { get; set; }
        public Guid CatalogId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public Guid AgentId { get; set; }
        public Guid PostId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid? CategoryId { get; set; }
        public decimal? ProffKoef { get; set; }
        public decimal? WorkExp { get; set; }
        public string AcademicDegree { get; set; }
        public string AcademicTitle { get; set; }
        public string Education { get; set; }
        public string AddEducation { get; set; }
        public short? RatingEducation { get; set; }
        public short? RatingAddEducation { get; set; }
        public short? RatingAcademicDegree { get; set; }
        public short? RatingPost { get; set; }
        public short? RatingCurrentWork1 { get; set; }
        public short? RatingCurrentWork2 { get; set; }
        public short? RatingCurrentWork3 { get; set; }
        public short? RatingCurrentWork4 { get; set; }
        public short? RatingCurrentWork5 { get; set; }
    }
}
