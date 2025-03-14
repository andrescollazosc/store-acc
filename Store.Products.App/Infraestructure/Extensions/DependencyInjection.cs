using Store.Products.Core.BundledProducts.Services;
using Store.Products.Core.BundledProducts.Services.Impl;

namespace Store.Products.App.Infraestructure.Extensions;

public static class DependencyInjection
{
    public static void RegisterDependencies(this IServiceCollection services)
    {
        services.AddScoped<IProductService, ProductService>();
    }
}