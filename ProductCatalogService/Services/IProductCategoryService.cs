using ProductCatalogService.Models;

namespace ProductCatalogService.Services;

public interface IProductCategoryService
{
    Task<ProductCategory> GetProductCategoryByIdAsync(int productCategoryId);
}