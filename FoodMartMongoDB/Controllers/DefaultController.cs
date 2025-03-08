using FoodMartMongoDB.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IProductService _productService;

        public DefaultController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult UILayout()
        {
            return View();
        }

        public IActionResult AdminLayout()
        {
            return View();
        }
        
        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}
