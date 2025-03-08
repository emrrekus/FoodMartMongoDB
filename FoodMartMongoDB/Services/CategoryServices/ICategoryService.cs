using System;
using FoodMartMongoDB.Dtos.CategoryDTOS;

namespace FoodMartMongoDB.Services.CategoryService;

public interface ICategoryService
{   
        Task <List<ResultCategoryDto>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(string Id);
        Task<GetByIDCategoryDto> GetByIDCategoryAsync(string Id);

}
