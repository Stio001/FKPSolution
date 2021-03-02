using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class VSystemSetting
    {
        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? CatalogId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? LinkSection { get; set; }
        public Guid? LinkAttr { get; set; }
        public string LinksectionSysCode { get; set; }
        public string LinksectionCode { get; set; }
        public string AttName { get; set; }
        public string AttCaption { get; set; }
        public int? NType { get; set; }
        public bool? IsGlobal { get; set; }
        public string SettingValue { get; set; }
        public string SType { get; set; }
        public string UserName { get; set; }
        public string UserIdCode { get; set; }
        public string RoleIdCode { get; set; }
    }
}
