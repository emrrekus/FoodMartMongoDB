using System;
using FoodMartMongoDB.Dtos.SaleDTOS;

namespace FoodMartMongoDB.Services.SalesServices;

public interface ISaleService
{

        Task<List<ResultSaleDto>> GetAllSaleAsync();
        Task CreateSaleAsync(CreateSaleDto createSaleDto);
        Task UpdateSaleAsync(UpdateSaleDto updateSaleDto);
        Task DeleteSaleAsync(string Id);
        Task<GetByIDSaleDto> GetByIDSaleAsync(string Id);
         Task<List<ResultSaleProductDto>> GetAllSaleWithProductAsync();
}
