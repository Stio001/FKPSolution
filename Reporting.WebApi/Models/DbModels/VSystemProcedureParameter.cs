using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemProcedureParameter
    {
        public string ParameterName { get; set; }
        public string ParameterMode { get; set; }
        public string DataType { get; set; }
        public int? CharacterMaximumLength { get; set; }
        public byte? NumericPrecision { get; set; }
        public int? NumericScale { get; set; }
        public string SpecificName { get; set; }
    }
}
