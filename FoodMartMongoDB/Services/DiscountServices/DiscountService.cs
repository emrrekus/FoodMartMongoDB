using System;
using AutoMapper;
using FoodMartMongoDB.Dtos.DiscountDTOS;
using FoodMartMongoDB.Entities;
using FoodMartMongoDB.Settings;
using MongoDB.Driver;

namespace FoodMartMongoDB.Services.DiscountServices;

public class DiscountService : IDiscountService
{

      private readonly IMongoCollection<Discount> _discountCollection;
        private readonly IMapper _mapper;

        public DiscountService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _discountCollection = database.GetCollection<Discount>(_databaseSettings.DiscountCollectionName);
            _mapper = mapper;
        }

        public async Task CreateDiscountAsync(CreateDiscountDto createDiscountDto)
        {
           var value = _mapper.Map<Discount>(createDiscountDto);
           await _discountCollection.InsertOneAsync(value);
        }

        public async Task DeleteDiscountAsync(string Id)
        {
            await _discountCollection.DeleteOneAsync(x => x.Id == Id);
        }

        public async Task<List<ResultDiscountDto>> GetAllDiscountAsync()
        {
            var values = await _discountCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultDiscountDto>>(values);
        }

        public async Task<GetByIDDiscountDto> GetByIDDiscountAsync(string Id)
        {
            var value = await _discountCollection.Find(x => x.Id == Id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIDDiscountDto>(value);
        }

        public async Task UpdateDiscountAsync(UpdateDiscountDto updateDiscountDto)
        {
            var values = _mapper.Map<Discount>(updateDiscountDto);
            await _discountCollection.FindOneAndReplaceAsync(x=>x.Id == updateDiscountDto.Id, values);
        }
}
