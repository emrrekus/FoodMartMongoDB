using FoodMartMongoDB.Dtos.SaleDTOS;
using FoodMartMongoDB.Services.SalesServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.Controllers
{
    
    public class SaleController : Controller
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

      

        public async Task<IActionResult> SaleList()
        {
            var values = await _saleService.GetAllSaleWithProductAsync();       
            return View(values);
        }

        public IActionResult CreateSale()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSale(CreateSaleDto createSaleDto)
        {
            createSaleDto.SaleDate = DateTime.UtcNow;
            await _saleService.CreateSaleAsync(createSaleDto);
            return RedirectToAction("SaleList");
        }
        public async Task<IActionResult> DeleteSale(string id)
        {
            await _saleService.DeleteSaleAsync(id);
            return RedirectToAction("SaleList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateSale(string id)
        {
            var value = await _saleService.GetByIDSaleAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSale(UpdateSaleDto updateSaleDto)
        {
            updateSaleDto.SaleDate = DateTime.UtcNow;
            await _saleService.UpdateSaleAsync(updateSaleDto);
            return RedirectToAction("SaleList");
        }

    }
}
