using Store.Products.Core.BundledProducts.Models;

namespace Store.Products.Core.BundledProducts.Services.Impl;

public class ProductService : IProductService
{
    public async Task<IEnumerable<Product>> GetProducts()
    {
        return await Task.FromResult<IEnumerable<Product>>(ProductMock.GetProducts().ToList());
    }

    public Task<Product> GetProduct(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> Create(Product product)
    {
        throw new NotImplementedException();
    }
}