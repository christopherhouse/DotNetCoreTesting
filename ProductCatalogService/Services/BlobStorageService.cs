namespace ProductCatalogService.Services;

public class BlobStorageService : IBlobStorageService
{
    private readonly string _connectionString;

    public BlobStorageService(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentException(nameof(connectionString));
        }

        _connectionString = connectionString;
    }
}