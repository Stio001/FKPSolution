using System;

namespace Analysis.WebApi.Models.Dto
{
    public class DocTypeForUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
