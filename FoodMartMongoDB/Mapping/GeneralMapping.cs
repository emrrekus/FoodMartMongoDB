using System;
using AutoMapper;
using FoodMartMongoDB.Dtos.CategoryDTOS;
using FoodMartMongoDB.Dtos.DiscountDTOS;
using FoodMartMongoDB.Dtos.FeatureDTOS;
using FoodMartMongoDB.Dtos.ProductDTOS;
using FoodMartMongoDB.Dtos.SaleDTOS;
using FoodMartMongoDB.Entities;

namespace FoodMartMongoDB.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<Category, ResultCategoryDto>().ReverseMap();
        CreateMap<Category, GetByIDCategoryDto>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
        CreateMap<Category, UpdateCategoryDto>().ReverseMap();

        CreateMap<Product, ResultProductDto>().ReverseMap();
        CreateMap<Product, GetByIDProductDto>().ReverseMap();
        CreateMap<Product, CreateProductDto>().ReverseMap();
        CreateMap<Product, UpdateProductDto>().ReverseMap();

        CreateMap<Sales, ResultSaleDto>().ReverseMap();
        CreateMap<Sales, GetByIDSaleDto>().ReverseMap();
        CreateMap<Sales, CreateSaleDto>().ReverseMap();
        CreateMap<Sales, UpdateSaleDto>().ReverseMap();


        CreateMap<Discount, ResultDiscountDto>().ReverseMap();
        CreateMap<Discount, GetByIDDiscountDto>().ReverseMap();
        CreateMap<Discount, CreateDiscountDto>().ReverseMap();
        CreateMap<Discount, UpdateDiscountDto>().ReverseMap();

        CreateMap<Feature, ResultFeatureDto>().ReverseMap();
        CreateMap<Feature, GetByIDFeatureDto>().ReverseMap();
        CreateMap<Feature, CreateFeatureDto>().ReverseMap();
        CreateMap<Feature, UpdateFeatureDto>().ReverseMap();


        CreateMap<Product, ResultProductCategoryDto>()
        .ForMember(x => x.CategoryName, y => y.MapFrom(z => z.Category.CategoryName));
        
        
        CreateMap<Sales, ResultSaleProductDto>()
        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Product.Name))
        .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Product.Price))
        .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Product.Image));




        
        
        
    }
}
