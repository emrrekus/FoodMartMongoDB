using System;

namespace FoodMartMongoDB.Dtos.SaleDTOS;

public class ResultSaleProductDto
{
     public string Id { get; set; }
    public int Count { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTimeOffset SaleDate { get; set; }

    public string Name { get; set; }
    public string Image { get; set; }
    public int Price { get; set; }
}
