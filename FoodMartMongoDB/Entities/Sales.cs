using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FoodMartMongoDB.Entities;

public class Sales
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
    public DateTimeOffset SaleDate { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string ProductId { get; set; }
    [BsonIgnore]
    public Product Product { get; set; }

    
  
}
