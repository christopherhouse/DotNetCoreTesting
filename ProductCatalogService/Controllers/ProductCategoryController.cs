using Microsoft.AspNetCore.Mvc;

namespace ProductCatalogService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductCategoryController : ControllerBase
{
    private readonly IProductCategoryService _productCategoryService;

    public ProductCategoryController(IProductCategoryService productCategoryService)
    {
        ArgumentNullException.ThrowIfNull(productCategoryService);
        _productCategoryService = productCategoryService;
    }
}