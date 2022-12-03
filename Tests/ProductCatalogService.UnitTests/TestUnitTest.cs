using FluentAssertions;

namespace ProductCatalogService.UnitTests;

public class TestUnitTest
{
    [Fact]
    public void True_Should_Be_True()
    {
        true.Should()
            .BeTrue();
    }
}