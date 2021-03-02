using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VMmWorkPersonContribution
    {
        public Guid Rid { get; set; }
        public Guid StageId { get; set; }
        public Guid PersonId { get; set; }
        public decimal ContributionValue { get; set; }
        public decimal? PersonRaiting { get; set; }
        public DateTime CalcDate { get; set; }
        public string PersonCode { get; set; }
        public string PersonDepartment { get; set; }
        public string PersonPost { get; set; }
        public DateTime StageDateFrom { get; set; }
        public DateTime StageDateTo { get; set; }
        public string GroupRoleName { get; set; }
    }
}
