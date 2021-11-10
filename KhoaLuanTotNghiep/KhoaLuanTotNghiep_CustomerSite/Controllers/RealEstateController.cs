using KhoaLuanTotNghiep_CustomerSite.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_CustomerSite.Controllers
{
    public class RealEstateController : Controller
    {
        private readonly IRealEstateApiClient _realestateApiClient;

        public RealEstateController(IRealEstateApiClient productApiClient)
        {
            _realestateApiClient = productApiClient;
        }

        [Route("/RealEstate")]
        public async Task<IActionResult> Index()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _realestateApiClient.GetProducts();
            if (result == null)
                return NotFound();
            return View(result);
        }

        [Route("/RealEstate/{id}")] 
        public async Task<IActionResult> Details(string id)
        {
            if (!ModelState.IsValid && string.IsNullOrEmpty(id))
            {
                return BadRequest(id);
            }

            var result = await _realestateApiClient.GetProductById(id);
            if (result == null)
                return NotFound();
            return View(result);
        }

        [Route("/RealEstate/category{categoryName}")]
        public async Task<IActionResult> CategoryById(string categoryName)
        {
            if (!ModelState.IsValid && string.IsNullOrEmpty(categoryName))
            {
                return BadRequest();
            }

            var result = await _realestateApiClient.GetProductByCategory(categoryName);
            if (result == null)
                return NotFound();
            return View(result);
        }
    }
}
