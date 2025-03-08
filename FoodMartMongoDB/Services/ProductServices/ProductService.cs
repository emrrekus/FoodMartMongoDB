using System;
using AutoMapper;
using FoodMartMongoDB.Dtos.ProductDTOS;
using FoodMartMongoDB.Entities;
using FoodMartMongoDB.Settings;
using MongoDB.Driver;

namespace FoodMartMongoDB.Services.ProductServices;

public class ProductService : IProductService
{

         private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Category> _categoryCollection;

        public ProductService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _categoryCollection = database.GetCollection <Category>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductAsync(CreateProductDto createProductDto)
        {
            var value = _mapper.Map<Product>(createProductDto);
            await _productCollection.InsertOneAsync(value);
        }

        public async Task DeleteProductAsync(string Id)
        {
            await _productCollection.DeleteOneAsync(x => x.Id == Id);
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            var values = await _productCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDto>>(values);
        }

        public async Task<List<ResultProductCategoryDto>> GetAllProductWithCategoryAsync()
        {
            var values = await _productCollection.Find(x => true).ToListAsync();
            foreach (var item in values)
            {
                item.Category = await _categoryCollection.Find(x => x.Id == item.CategoryId).FirstOrDefaultAsync();
            }
            return _mapper.Map<List<ResultProductCategoryDto>>(values);
        }

        public async Task<GetByIDProductDto> GetByIDProductAsync(string Id)
        {
            var value = await _productCollection.Find(x => x.Id == Id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIDProductDto>(value);
        }

        public async Task<List<ResultProductCategoryDto>> GetProductByCategoryIDAsync(string id)
        {
            var values = await _productCollection.Find(x => x.Id == id).ToListAsync();
            foreach (var item in values)
            {
                item.Category = await _categoryCollection.Find(x => x.Id == item.CategoryId).FirstOrDefaultAsync();
            }
            return _mapper.Map<List<ResultProductCategoryDto>>(values);
        }

       


        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var values = _mapper.Map<Product>(updateProductDto);
            await _productCollection.FindOneAndReplaceAsync(x=>x.ProductID == updateProductDto.ProductID,values);
        }
}
