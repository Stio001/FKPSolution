using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VWorkFinanceWorkPlaceDshb01
    {
        public decimal? ЗначениеФинансовогоПоказателя { get; set; }
        public string Версия { get; set; }
        public int? ПоказательФинансированияПоГодам { get; set; }
        public string ВидФинансирования { get; set; }
    }
}
