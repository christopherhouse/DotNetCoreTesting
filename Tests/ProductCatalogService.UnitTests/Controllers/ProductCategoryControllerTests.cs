using System.Net;
using AutoFixture;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using ProductCatalogService.Controllers;
using ProductCatalogService.Models;
using ProductCatalogService.Services;

namespace ProductCatalogService.UnitTests.Controllers;

public class ProductCategoryControllerTests : BaseUnitTest
{
    private readonly ProductCategoryController _categoryController;
    private readonly Mock<IProductCategoryService> _productCategoryService;

    public ProductCategoryControllerTests()
    {
        _productCategoryService = this.Repository.Create<IProductCategoryService>();
        _categoryController = new ProductCategoryController(_productCategoryService.Object);
    }

    [Fact]
    public void Constructor_Should_Throw_ArgumentNullException_If_IProductCategoryService_Is_Null()
    {
        // Arrange
        IProductCategoryService service = null;
        Action ctor = () => new ProductCategoryController(service);

        // Act + Assert
        ctor.Should()
            .Throw<ArgumentNullException>();
    }

    [Fact]
    public async Task GetProductCategoryById_Should_Return_Single_ProductCategory()
    {
        // Arrange
        var category = TestFixture.Create<ProductCategory>();
        var productCategoryId = TestFixture.Create<int>();
        _productCategoryService.Setup(_ => _.GetProductCategoryById(It.Is<int>(id => id == productCategoryId)))
            .Returns(category);

        // Act
        var productCategoryResult = _categoryController.GetProductCategoryById(productCategoryId);

        // Assert
        this.Repository.VerifyAll();
        var okObjectResult = productCategoryResult as OkObjectResult;

        okObjectResult.Should()
            .NotBeNull();

        okObjectResult.StatusCode
            .Should()
            .Be((int)HttpStatusCode.OK);

        var actualCategory = okObjectResult.Value as ProductCategory;
        actualCategory.Should()
            .NotBeNull();

        actualCategory.Should()
            .Be(category);
    }

    [Fact]
    public void GetProductCategoryById_Should_Return_404_When_ProductCategory_Is_Not_Found()
    {
        // Arrange
        var productCategoryId = TestFixture.Create<int>();
        _productCategoryService.Setup(_ => _.GetProductCategoryById(It.Is<int>(id => id == productCategoryId)))
            .Returns<ProductCategory>(null);

        // Act
        var result = _categoryController.GetProductCategoryById(productCategoryId);

        // Assert
        _productCategoryService.VerifyAll();

        result.Should()
            .NotBeNull();

        var notFoundResult = result as NotFoundResult;

        notFoundResult.Should()
            .NotBeNull();

        notFoundResult.StatusCode
            .Should()
            .Be((int)HttpStatusCode.NotFound);
    }
}