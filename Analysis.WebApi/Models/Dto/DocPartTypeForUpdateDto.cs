using System;

namespace Analysis.WebApi.Models.Dto
{
    public class DocPartTypeForUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string KeyWords { get; set; }
    }
}
