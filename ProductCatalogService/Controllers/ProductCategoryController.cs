using Microsoft.AspNetCore.Mvc;
using ProductCatalogService.Services;

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

    [HttpGet]
    public async Task<IActionResult> GetProductCategoryByIdAsync(int productCategoryId)
    {
        IActionResult result = null;
        var category = await _productCategoryService.GetProductCategoryByIdAsync(productCategoryId);

        if (category == null)
        {
            result = new NotFoundResult();
        }
        else
        {
            result = new OkObjectResult(category);
        }

        return result;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProductCategories()
    {
        IActionResult result = null;

        try
        {
            var products = await _productCategoryService.GetAllProductsAsync();
            result = new OkObjectResult(products);
        }
        catch (Exception e)
        {
            result = new StatusCodeResult(500);
        }

        return result;
    }
}