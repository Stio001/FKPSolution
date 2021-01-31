using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporting.WebApi.Services
{
    public class JwtIssuerOptions
    {
        public static string Issuer { get; set; }
        public static string Audience { get; set; }
        public static string TokenKey { get; set; }
    }
}
