using KhoaLuanTotNghiep_BackEnd.InterfaceService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShareModel;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize("Bearer")]

    public class RateController : ControllerBase
    {
        private readonly IRate _rate;

        public RateController(IRate rate)
        {
            _rate = rate;

        }

        [HttpPost]
        //[Authorize(Policy = SecurityConstants.ADMIN_ROLE_POLICY)]
        [AllowAnonymous]
        public async Task<IActionResult> CreateRate([FromBody] CreateRatingRequest rateShare)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(rateShare);
            }

            var result = await _rate.CreateRate(rateShare);
            if (result == null)
                return NotFound();
            return Ok(result);
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetListRatingAsync(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _rate.GetListRatingAsync(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }
    }
}
