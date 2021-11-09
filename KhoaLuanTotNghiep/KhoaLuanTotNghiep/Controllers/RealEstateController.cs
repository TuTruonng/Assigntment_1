using KhoaLuanTotNghiep_BackEnd.InterfaceService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ShareModel;
using ShareModel.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Controllers
{
    [Route("[controller]")]
    [EnableCors("AllowOrigins")]
    [ApiController]
    [Authorize("Bearer")]

    public class RealEstateController : ControllerBase
    {
        public readonly IRealEstate _realStateService;

        public RealEstateController(IRealEstate realStatrService)
        {
            _realStateService = realStatrService;
        }

        [HttpGet]
        [AllowAnonymous]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<ActionResult<RealEstateModel>> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _realStateService.GetAllAsync();
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<ActionResult> GetById(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _realStateService.GetByIdAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("category={categoryName}")]
        [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<ActionResult> GetByCategory(string categoryName)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(categoryName);
            }

            var result = await _realStateService.GetByCategoryAsync(categoryName);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<ActionResult<RealEstateModel>> CreateAsync([FromForm] RealEstateModel productShare)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(productShare);
            }

            var result = await _realStateService.CreateRealEstatesAsync(productShare);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<IActionResult> Delete(string id)
        {
            if (!ModelState.IsValid && string.IsNullOrEmpty(id))
            {
                return BadRequest(id);
            }

            var result = await _realStateService.DeleteRealEstateModelAsync(id);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id}")]
        //[AllowAnonymous]
        [Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        public async Task<ActionResult> UpdateAsync(string id, [FromForm] RealEstateModel model)
        {
            if (!ModelState.IsValid && string.IsNullOrEmpty(id))
            {
                return BadRequest(id);
            }

            var result = await _realStateService.UpdateRealEstateAsync(id, model);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

    }
}
