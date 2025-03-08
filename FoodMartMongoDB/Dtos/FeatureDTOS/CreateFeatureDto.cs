using System;

namespace FoodMartMongoDB.Dtos.FeatureDTOS;

public class CreateFeatureDto
{
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
} 