using KhoaLuanTotNghiep_CustomerSite.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_CustomerSite.Controllers
{
    public class RateController : Controller
    {
        private readonly IRealEstateApiClient _realEstateApiClient;

        public RateController(IRealEstateApiClient realEstateApiClient)
        {
            _realEstateApiClient = realEstateApiClient;
        }

        public async Task<IActionResult> Voting(string ProductID, int rating)
        {
            if (!ModelState.IsValid || ProductID is null)
            {
                return NotFound();
            }

            string uri_Redirect = Request.Headers["Referer"].ToString();
            var result = await _realEstateApiClient.Rating(ProductID, rating);

            if (result is false)
            {
                return Content("false");
            }
            return Redirect(uri_Redirect);
        }
    }
}
