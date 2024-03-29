﻿using Microsoft.AspNetCore.Mvc;
using ProductCatalogService.Models;
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
}