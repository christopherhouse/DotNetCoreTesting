namespace ProductCatalogService.Models;

public class ProductCategory
{
    public int ProductCategoryId { get; set; }

    public string CategoryName { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public Guid CreatedByUserId { get; set; }

    public Guid UpdatedByUserId { get;set; }
}