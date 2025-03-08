using FoodMartMongoDB.Dtos.CategoryDTOS;
using FoodMartMongoDB.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryService.GetAllCategoryAsync();
            return View(values);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateCategoryAsync(createCategoryDto);
            return RedirectToAction("CategoryList");
        }
        public async Task<IActionResult> DeleteCategory(string id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCategory(string id)
        {
          var value = await _categoryService.GetByIDCategoryAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            await _categoryService.UpdateCategoryAsync(updateCategoryDto);
            return RedirectToAction("CategoryList");
        }
    }
}
