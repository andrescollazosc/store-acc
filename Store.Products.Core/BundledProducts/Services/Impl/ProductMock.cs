using Store.Products.Core.BundledProducts.Models;

namespace Store.Products.Core.BundledProducts.Services.Impl;

public class ProductMock
{
    public static IEnumerable<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Id = Guid.NewGuid(), Name = "Product 1", Description = "Description 1", Price = 2000},
            new Product { Id = Guid.NewGuid(), Name = "Product 2", Description = "Description 2", Price = 2500 },
            new Product { Id = Guid.NewGuid(), Name = "Product 3", Description = "Description 3", Price = 3000 },
            new Product { Id = Guid.NewGuid(), Name = "Product 4", Description = "Description 4", Price = 4000 },
            new Product { Id = Guid.NewGuid(), Name = "Product 5", Description = "Description 5", Price = 5000 },
            new Product { Id = Guid.NewGuid(), Name = "Product 6", Description = "Description 6", Price = 6000 },
            new Product { Id = Guid.NewGuid(), Name = "Product 7", Description = "Description 7", Price = 7000 },
            new Product { Id = Guid.NewGuid(), Name = "Product 8", Description = "Description 8",  Price = 8000 },
            new Product { Id = Guid.NewGuid(), Name = "Product 9", Description = "Description 9", Price = 9000 },
            new Product { Id = Guid.NewGuid(), Name = "Product 10", Description = "Description 10", Price = 1000 },
        };
    }
}