using System;

namespace FoodMartMongoDB.Dtos.CategoryDTOS;

public class GetByIDCategoryDto
{
    public string Id { get; set; }
    public string Image { get; set; }
    public string CategoryName { get; set; }
}
