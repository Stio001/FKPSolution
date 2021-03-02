using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VWorkOrbitalGroupWorkPlace
    {
        public decimal? ЗначениеКоличественногоПоказателя { get; set; }
        public string Версия { get; set; }
        public string ШифрМероприятия { get; set; }
        public string МнемокодМероприятия { get; set; }
        public string КоличествоЗапусковПоГодам { get; set; }
        public string НаименованиеМероприятия { get; set; }
        public int? ТипМероприятия { get; set; }
        public int? КатегорияМероприятия { get; set; }
        public int? НаправлениеМероприятия { get; set; }
        public string РазделПодразделМероприятия { get; set; }
        public string НаименованиеКа { get; set; }
        public string РакетаНоситель { get; set; }
        public string РазгонныйБлок { get; set; }
        public string Космодром { get; set; }
        public Guid? Rid { get; set; }
        public Guid ParamId { get; set; }
        public Guid VersionId { get; set; }
    }
}
