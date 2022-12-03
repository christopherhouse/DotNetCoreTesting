namespace ProductCatalogService.UnitTests
{
    public abstract class BaseUnitTest
    {

        protected BaseUnitTest()
        {
            Repository = new MockRepository(MockBehavior.Strict);
        }

        protected virtual MockRepository Repository { get; }

        
    }
}