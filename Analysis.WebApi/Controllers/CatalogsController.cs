﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Analysis.WebApi.Models;
using Analysis.WebApi.Models.DbModels;
using Analysis.WebApi.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Analysis.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatalogsController : ControllerBase
    {
        private readonly AnalysisContext _analysisContext;

        public CatalogsController(AnalysisContext analysisContext)
        {
            _analysisContext = analysisContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var catalogs = await _analysisContext.Catalogs.ToListAsync();

            return new ObjectResult(catalogs);
        }

        [HttpGet("{catalogId}")]
        public async Task<IActionResult> Get(Guid catalogId)
        {
            var catalog = await _analysisContext.Catalogs.FindAsync(catalogId);

            if (catalog == null)
                return NotFound();

            return new ObjectResult(catalog);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CatalogToCreateDto model)
        {
            Catalog catalog = new Catalog()
            {
                Name = model.Name,
                Description = model.Description,
                ParentId = model.ParentId
            };

            try
            {
                await _analysisContext.Catalogs.AddAsync(catalog);
                await _analysisContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit(CatalogForUpdateDto model)
        {
            var catalog = await _analysisContext.Catalogs.FirstOrDefaultAsync(c => c.Id == model.Id);

            if (catalog == null)
                return BadRequest("Каталог не найден.");

            catalog.Description = model.Description;

            try
            {
                _analysisContext.Update(catalog);
                await _analysisContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            

            return Ok();
        }

        [HttpDelete("{catalogId}")]
        public async Task<IActionResult> Delete(Guid catalogId)
        {
            var catalog = await _analysisContext.Catalogs.FirstOrDefaultAsync(c => c.Id == catalogId);

            if (catalog == null)
                return BadRequest("Каталог не найден.");

            try
            {
                _analysisContext.Catalogs.Remove(catalog);
                await _analysisContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok();
        }
    }
}
