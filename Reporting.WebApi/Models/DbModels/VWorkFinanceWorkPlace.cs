using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VWorkFinanceWorkPlace
    {
        public decimal? ЗначениеФинансовогоПоказателя { get; set; }
        public string Версия { get; set; }
        public int? ПоказательФинансированияПоГодам { get; set; }
        public string НаименованиеМероприятия { get; set; }
        public string РегистрационныйНомерМероприятия { get; set; }
        public string НомерМероприятияВПрограмме { get; set; }
        public string ВидФинансирования { get; set; }
        public string ШифрПроекта { get; set; }
        public string Исполнитель { get; set; }
        public Guid Rid { get; set; }
        public Guid ParamId { get; set; }
        public Guid? VersionId { get; set; }
        public decimal? LimitSum { get; set; }
        public decimal? DiffLimitSum { get; set; }
        public string Раздел { get; set; }
        public string Подраздел { get; set; }
        public string Статья { get; set; }
        public string Пункт { get; set; }
        public int? Приоритет { get; set; }
        public string СокрНаименование { get; set; }
        public Guid WorkId { get; set; }
        public int? UseInGraph { get; set; }
    }
}
