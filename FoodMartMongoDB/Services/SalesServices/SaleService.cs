using System;
using AutoMapper;
using FoodMartMongoDB.Dtos.SaleDTOS;
using FoodMartMongoDB.Entities;
using FoodMartMongoDB.Settings;
using MongoDB.Driver;

namespace FoodMartMongoDB.Services.SalesServices;

public class SaleService : ISaleService
{
    private readonly IMongoCollection<Sales> _saleCollection;
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Product> _productCollection;
        public SaleService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _saleCollection = database.GetCollection<Sales>(_databaseSettings.SalesCollectionName);
            _productCollection = database.GetCollection<Product>(_databaseSettings.ProductCollectionName);
            _mapper = mapper;
        }

        public async Task CreateSaleAsync(CreateSaleDto createSaleDto)
        {
            var values =  _mapper.Map<Sales>(createSaleDto);
            await _saleCollection.InsertOneAsync(values);
        }

        public async Task DeleteSaleAsync(string Id)
        {
             await _saleCollection.DeleteOneAsync(x=>x.Id == Id);
        }

        public async Task<List<ResultSaleDto>> GetAllSaleAsync()
        {
            var values = await _saleCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultSaleDto>>(values);
        }

        public async Task<List<ResultSaleProductDto>> GetAllSaleWithProductAsync()
        {
            var saleList = await _saleCollection.Find(x => true).ToListAsync();
            foreach (var item in saleList)
            {
                item.Product = await _productCollection.Find(x => x.Id == item.ProductId).FirstOrDefaultAsync();
            }
            return _mapper.Map<List<ResultSaleProductDto>>(saleList);

        }

        public async Task<GetByIDSaleDto> GetByIDSaleAsync(string Id)
        {
            var value = await _saleCollection.Find(x => x.Id == Id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIDSaleDto>(value);
        }

        public async Task UpdateSaleAsync(UpdateSaleDto updateSaleDto)
        {
           var values = _mapper.Map<Sales>(updateSaleDto);
           await _saleCollection.FindOneAndReplaceAsync(x=>x.Id == updateSaleDto.Id,values);
        }

}
