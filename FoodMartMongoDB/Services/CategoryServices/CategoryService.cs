using System;
using AutoMapper;
using FoodMartMongoDB.Dtos.CategoryDTOS;
using FoodMartMongoDB.Entities;
using FoodMartMongoDB.Settings;
using MongoDB.Driver;

namespace FoodMartMongoDB.Services.CategoryService;

public class CategoryService : ICategoryService
{

     private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }

        public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
           var value = _mapper.Map<Category>(createCategoryDto);
           await _categoryCollection.InsertOneAsync(value);
        }

        public async Task DeleteCategoryAsync(string Id)
        {
            await _categoryCollection.DeleteOneAsync(x => x.Id == Id);
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            var values = await _categoryCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultCategoryDto>>(values);
        }

        public async Task<GetByIDCategoryDto> GetByIDCategoryAsync(string Id)
        {
            var value = await _categoryCollection.Find(x => x.Id == Id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIDCategoryDto>(value);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);
            await _categoryCollection.FindOneAndReplaceAsync(x => x.Id == updateCategoryDto.Id, value);
        }

}
