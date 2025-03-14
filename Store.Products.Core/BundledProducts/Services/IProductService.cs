using Store.Products.Core.BundledProducts.Models;

namespace Store.Products.Core.BundledProducts.Services;

public interface IProductService
{
    Task<IEnumerable<Product>> GetProducts();
    Task<Product> GetProduct(Guid id);
    Task<Product> Create(Product product);
}