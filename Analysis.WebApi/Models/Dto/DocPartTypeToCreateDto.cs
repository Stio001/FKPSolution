using System;

namespace Analysis.WebApi.Models.Dto
{
    public class DocPartTypeToCreateDto
    {
        public string Name { get; set; }
        public string KeyWords { get; set; }

        public Guid DocTypeId { get; set; }
    }
}
