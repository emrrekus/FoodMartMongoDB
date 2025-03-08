using System;

namespace FoodMartMongoDB.Dtos.ProductDTOS;

public class UpdateProductDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
    public string Image { get; set; }
    
} 