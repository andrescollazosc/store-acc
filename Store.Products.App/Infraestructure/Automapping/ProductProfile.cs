using AutoMapper;
using Store.Products.App.Controllers.Dtos;
using Store.Products.Core.BundledProducts.Models;

namespace Store.Products.App.Infraestructure.Automapping;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>();
    }
}