using System;

namespace FoodMartMongoDB.Dtos.CategoryDTOS;

public class UpdateCategoryDto
{
   public string Id { get; set; }
    public string Image { get; set; }
    public string CategoryName { get; set; }
}
