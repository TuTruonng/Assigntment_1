using KhoaLuanTotNghiep_BackEnd.Interface;
using KhoaLuanTotNghiep_BackEnd.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShareModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Controllers
{
    [Route("[controller]")]
    [ApiController]
    // [Authorize("Bearer")]
    public class CategoryController : ControllerBase
    {
        private readonly Icategory _categoryService;

        public CategoryController(Icategory categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<CategoryModel>>> GetListAsync()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _categoryService.GetListCategoryAsync();
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<CategoryModel>> CreateAsync(CategoryModel Model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(Model);
            }

            var result = await _categoryService.CreateCategoryAsync(Model);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoryModel>> UpdateAsync(string id, CategoryModel category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(category);
            }

            var result = await _categoryService.UpdateCategoryAsync(id, category);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteAsync(string id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(id);
            }

            var result = await _categoryService.DeleteCategoryAsync(id);
            return Ok(result);
        }
    }
}
