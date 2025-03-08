using System;
using FoodMartMongoDB.Dtos.ProductDTOS;

namespace FoodMartMongoDB.Services.ProductServices;

public interface IProductService
{   

      Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string Id);
        Task<GetByIDProductDto> GetByIDProductAsync(string Id);
        Task<List<ResultProductCategoryDto>> GetAllProductWithCategoryAsync();
        Task<List<ResultProductCategoryDto>> GetProductByCategoryIDAsync(string id);

}
