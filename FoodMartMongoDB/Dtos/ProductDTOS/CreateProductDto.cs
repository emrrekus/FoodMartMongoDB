using System;

namespace FoodMartMongoDB.Dtos.ProductDTOS;

public class CreateProductDto
{
    public string Name { get; set; }
    public string Price { get; set; }
    public string Image { get; set; }
    public string CategoryId { get; set; }
} 