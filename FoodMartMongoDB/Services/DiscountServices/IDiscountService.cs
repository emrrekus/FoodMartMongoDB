using System;
using FoodMartMongoDB.Dtos.DiscountDTOS;

namespace FoodMartMongoDB.Services.DiscountServices;

public interface IDiscountService
{

      Task<List<ResultDiscountDto>> GetAllDiscountAsync();
        Task CreateDiscountAsync(CreateDiscountDto createDiscountDto);
        Task UpdateDiscountAsync(UpdateDiscountDto updateDiscountDto);
        Task DeleteDiscountAsync(string Id);
        Task<GetByIDDiscountDto> GetByIDDiscountAsync(string Id);

}
