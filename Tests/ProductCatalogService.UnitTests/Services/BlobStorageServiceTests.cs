using ProductCatalogService.Services;
using ProductCatalogService.UnitTests.TheoryProviders;

namespace ProductCatalogService.UnitTests.Services;

public class BlobStorageServiceTests
{
    [Theory()]
    [ClassData(typeof(InvalidStringProvider))]
    public void Constructor_Should_Throw_ArgumentException_For_Invalid_String(string connectionString)
    {
        // Arrange + Act
        var ctor = () => new BlobStorageService(connectionString);

        // Assert
        ctor.Should()
            .Throw<ArgumentException>();
    }
}