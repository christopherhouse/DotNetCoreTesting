using ProductCatalogService.Controllers;

namespace ProductCatalogService.UnitTests.Controllers;

public class ProductCategoryControllerTests : BaseUnitTest
{
    public ProductCategoryControllerTests()
    {
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
}