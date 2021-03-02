using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class TmpRiscFactorCombination
    {
        public Guid Rid { get; set; }
        public int? Numb { get; set; }
        public string Acombination { get; set; }
        public string Pcombination { get; set; }
        public int? Fcount { get; set; }
    }
}
