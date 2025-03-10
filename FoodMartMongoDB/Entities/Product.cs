using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FoodMartMongoDB.Entities;

public class Product
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
    public string Image { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string CategoryId { get; set; }
    [BsonIgnore]
    public Category Category { get; set; }
}
