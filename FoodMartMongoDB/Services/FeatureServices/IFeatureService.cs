using System;
using FoodMartMongoDB.Dtos.FeatureDTOS;

namespace FoodMartMongoDB.Services.FeatureService;

public interface IFeatureService
{
        Task<List<ResultFeatureDto>> GetAllFeatureAsync();
        Task CreateFeatureAsync(CreateFeatureDto createFeatureDto);
        Task UpdateFeatureAsync(UpdateFeatureDto updateFeatureDto);
        Task DeleteFeatureAsync(string Id);
        Task<GetByIDFeatureDto> GetByIDFeatureAsync(string Id);
}
