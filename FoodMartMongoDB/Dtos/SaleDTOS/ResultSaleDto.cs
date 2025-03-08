using System;

namespace FoodMartMongoDB.Dtos.SaleDTOS;

public class ResultSaleDto
{
    public string Id { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
    public DateTimeOffset SaleDate { get; set; }
   
} 