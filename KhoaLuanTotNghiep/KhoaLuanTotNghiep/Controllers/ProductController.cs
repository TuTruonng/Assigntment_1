using KhoaLuanTotNghiep_BackEnd.InterfaceService;
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
   
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<RealEstateModel>> Get()
        {
            var product = await _product.GetAllAsync();
            return Ok(product);
        }

        //[HttpGet]
        //[Route("{id}")]
        //[AllowAnonymous]
        //public async Task<ActionResult> GetById(int id)
        //{
        //    var result = await _product.GetByIdAsync(id);
        //    return Ok(result);
        //}

        //[HttpGet]
        //[Route("category={categoryName}")]
        //[AllowAnonymous]
        //public async Task<ActionResult> GetByCategory(string categoryName)
        //{
        //    var results = await _product.GetByCategoryAsync(categoryName);
        //    return Ok(results);
        //}

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<RealEstateModel>> Create([FromForm] RealEstateCreateRequest productShare)
        {

            var result = await _product.CreateAsync(productShare);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _product.DeleteAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        //[HttpPut]
        //[Route("{id}")]
        //public async Task<ActionResult> Update(int id, [FromForm] ProductCreateRequest model)
        //{
        //    var product = await _product.FindByIdAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    var result = await _product.UpdateAsync(id, model);
        //    return Ok(result);
        //}

    }
}
