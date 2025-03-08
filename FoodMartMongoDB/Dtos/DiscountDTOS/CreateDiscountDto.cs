using System;

namespace FoodMartMongoDB.Dtos.DiscountDTOS;

public class CreateDiscountDto
{
    public string Image { get; set; }
    public string Title { get; set; }
    public string Rate { get; set; }
    public string? Description { get; set; }
} 