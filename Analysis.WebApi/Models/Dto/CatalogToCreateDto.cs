﻿using System;

namespace Analysis.WebApi.Models.Dto
{
    public class CatalogToCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
    }
}
