using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VWorkFinanceWorkPlaceDshb03
    {
        public decimal? ЗначениеФинансовогоПоказателя { get; set; }
        public string Версия { get; set; }
        public int? ПоказательФинансированияПоГодам { get; set; }
        public string НаименованиеМероприятия { get; set; }
        public string ВидФинансирования { get; set; }
        public string ШифрПроекта { get; set; }
    }
}
