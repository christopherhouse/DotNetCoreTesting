using AutoFixture;

namespace ProductCatalogService.UnitTests
{
    public abstract class BaseUnitTest
    {
        protected BaseUnitTest()
        {
            Repository = new MockRepository(MockBehavior.Strict);
            TestFixture = new Fixture();
        }

        protected virtual MockRepository Repository { get; }

        protected virtual Fixture TestFixture { get; }
    }
}