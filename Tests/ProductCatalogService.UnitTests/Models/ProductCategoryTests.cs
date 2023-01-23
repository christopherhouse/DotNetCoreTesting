using AutoFixture;
using ProductCatalogService.Data.RepositoryModels;
using ProductCatalogService.Models;

namespace ProductCatalogService.UnitTests.Models
{
    public class ProductCategoryTests : BaseUnitTest
    {
        [Fact]
        public void FromProductCategoryRepositoryModel_Should_Return_A_New_Instance()
        {
            // Arrange
            var repoModel = TestFixture.Create<ProductCategoryRepositoryModel>();

            // Act
            var model = ProductCategory.FromProductCategoryRepositoryModel(repoModel);
            
            // Assert

            // Built-in XUnit assertion
            Assert.Equal(model.DateCreated, repoModel.DateCreated);

            // FluentAssertions
            model.CategoryName
                .Should()
                .Be(repoModel.CategoryName);

            model.CreatedByUserId
                .Should()
                .Be(repoModel.CreatedByUserId);

            model.DateUpdated
                .Should()
                .Be(repoModel.DateUpdated);

            model.ProductCategoryId
                .Should()
                .Be(repoModel.ProductCategoryId);

            model.UpdatedByUserId
                .Should()
                .Be(repoModel.UpdatedByUserId);
        }
    }
}
