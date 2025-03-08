using Microsoft.AspNetCore.Mvc;
using FoodMartMongoDB.Services.SalesServices;

namespace MongoDbFoodMart.ViewComponents
{
    public class _SellingUIComponentPartial : ViewComponent
    {
        private readonly ISaleService _saleService;

        public _SellingUIComponentPartial(ISaleService saleService)
        {
            _saleService = saleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _saleService.GetAllSaleWithProductAsync();
            return View(values);
        }
    }
}
