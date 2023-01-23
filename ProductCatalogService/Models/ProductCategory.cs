using ProductCatalogService.Data.RepositoryModels;

namespace ProductCatalogService.Models;

public class ProductCategory
{
    public int ProductCategoryId { get; set; }

    public string CategoryName { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public Guid CreatedByUserId { get; set; }

    public Guid UpdatedByUserId { get;set; }

    public static ProductCategory FromProductCategoryRepositoryModel(ProductCategoryRepositoryModel repoModel)
    {
        var model = new ProductCategory
        {
            ProductCategoryId = repoModel.ProductCategoryId,
            CategoryName = repoModel.CategoryName,
            DateCreated = repoModel.DateCreated,
            DateUpdated = repoModel.DateUpdated,
            CreatedByUserId = repoModel.CreatedByUserId,
            UpdatedByUserId = repoModel.UpdatedByUserId,
        };

        return model;
    }
}