using System;
using System.Collections.Generic;

#nullable disable

namespace Reporting.WebApi.Models.DbModels
{
    public partial class ParamParam
    {
        public ParamParam()
        {
            GroupParamParams = new HashSet<GroupParamParam>();
            StructureParams = new HashSet<StructureParam>();
            TechnicParams = new HashSet<TechnicParam>();
            TechnicTypeParams = new HashSet<TechnicTypeParam>();
            WorkParams = new HashSet<WorkParam>();
        }

        public Guid Rid { get; set; }
        public Guid? ParentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        public int DataType { get; set; }
        public Guid? MeasureId { get; set; }
        public Guid CatalogId { get; set; }
        public string Formula { get; set; }
        public Guid? ProcedureId { get; set; }
        public Guid? GroupId { get; set; }
        public int? LinkType { get; set; }
        public Guid? LinkSectionId { get; set; }
        public Guid? LinkFieldId { get; set; }

        public virtual CatalogCatalog Catalog { get; set; }
        public virtual GroupParamGroup Group { get; set; }
        public virtual DictionaryMeasure Measure { get; set; }
        public virtual UserProcedureProcedure Procedure { get; set; }
        public virtual ICollection<GroupParamParam> GroupParamParams { get; set; }
        public virtual ICollection<StructureParam> StructureParams { get; set; }
        public virtual ICollection<TechnicParam> TechnicParams { get; set; }
        public virtual ICollection<TechnicTypeParam> TechnicTypeParams { get; set; }
        public virtual ICollection<WorkParam> WorkParams { get; set; }
    }
}
