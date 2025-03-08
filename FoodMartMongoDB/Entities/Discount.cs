using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FoodMartMongoDB.Entities;

public class Discount
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Rate { get; set; }
    public string? Description { get; set; }

}
