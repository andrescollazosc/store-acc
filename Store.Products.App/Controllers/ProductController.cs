using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Store.Products.App.Controllers.Dtos;
using Store.Products.Core.BundledProducts.Services;

namespace Store.Products.App.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : Controller
{
    private IProductService ProductService { get; }
    private IMapper Mapper { get; }

    public ProductController(IProductService productService, IMapper mapper)
    {
        ProductService = productService;
        Mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
    {
        var products = await ProductService.GetProducts();
        var productsDto = products.Select(x => Mapper.Map<ProductDto>(x));
        
        return Ok(productsDto);
    }
}