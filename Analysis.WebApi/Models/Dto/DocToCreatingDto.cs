using System;

namespace Analysis.WebApi.Models.Dto
{
    public class DocToCreatingDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TypeId { get; set; }
    }
}
