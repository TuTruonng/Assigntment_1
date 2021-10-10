//using KhoaLuanTotNghiep_CustomerSite.Service;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace KhoaLuanTotNghiep_CustomerSite.Controllers
//{
//    public class ProductController : Controller
//    {
//        private readonly IProductApiClient _productApiClient;

//        public ProductController(IProductApiClient productApiClient)
//        {
//            _productApiClient = productApiClient;
//        }

//        [Route("/Product")]
//        public async Task<IActionResult> Index()
//        {
//            var results = await _productApiClient.GetProducts();
//            return View(results);
//        }

//        [Route("/Prodcut/{id}")]
//        public async Task<IActionResult> Details(int id)
//        {
//            var result = await _productApiClient.GetProductById(id);
//            return View(result);
//        }

//        [Route("/Prodcut/category{categoryName}")]
//        public async Task<IActionResult> CategoryById(string categoryName)
//        {
//            var results = await _productApiClient.GetProductByCategory(categoryName);
//            return View(results);
//        }
//    }
//}
