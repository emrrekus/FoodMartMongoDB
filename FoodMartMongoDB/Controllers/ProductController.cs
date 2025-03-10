using FoodMartMongoDB.Dtos.ProductDTOS;
using FoodMartMongoDB.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.Controllers
{
    public class ProductController : Controller
    {
       private readonly IProductService _productService;

        public ProductController(IProductService  productService )
        {
            _productService = productService;
        }

        public async Task<IActionResult> ProductList()
        {
            var values = await _productService.GetAllProductWithCategoryAsync();
            return View(values);
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("ProductList");
        }
      
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            var value = await _productService.GetByIDProductAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> GetProductByCategoryID(string id)
        {
            var values = await _productService.GetProductByCategoryIDAsync(id);
            return View(values);
        }

    }
}
