using FoodMartMongoDB.Services.DiscountServices;
using Microsoft.AspNetCore.Mvc;

namespace MongoDbFoodMart.ViewComponents
{
    public class _DiscountUILayoutComponentPartial : ViewComponent
    {
        private readonly IDiscountService _discountService;

        public _DiscountUILayoutComponentPartial(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _discountService.GetAllDiscountAsync();
            return View(values);
        }
    }
}
