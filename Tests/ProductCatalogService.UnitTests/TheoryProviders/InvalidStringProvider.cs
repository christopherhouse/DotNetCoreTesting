using System.Collections;

namespace ProductCatalogService.UnitTests.TheoryProviders
{
    public class InvalidStringProvider : IEnumerable<object[]>
    {
        private static readonly List<object[]> _data = new List<object[]>
        {
            new object[] { string.Empty },
            new object[] { " " },
            new object[] { "\t" },
            new object[] { Environment.NewLine },
            new object[] { null }
        };

        public IEnumerator<object[]> GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
