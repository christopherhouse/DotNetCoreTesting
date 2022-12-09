using ProductCatalogService.Models;

namespace ProductCatalogService.Services;

public interface IProductCategoryService
{
    ProductCategory GetProductCategoryById(int productCategoryId);
}