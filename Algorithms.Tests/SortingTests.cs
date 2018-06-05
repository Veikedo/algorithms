using System.Linq;
using Algorithms.Lib;
using Xunit;
using Xunit.Abstractions;

namespace Algorithms.Tests
{
    public class SortingTests
    {
        public SortingTests(ITestOutputHelper output)
        {
            _output = output;
            _sut = new[] {4, 1, 3, 2, 4, 7, 9, 50, 1, 74, 200, 30, 4, 7};
            _expected = _sut.OrderBy(x => x);
        }

        private readonly ITestOutputHelper _output;
        private readonly int[] _sut;
        private readonly IOrderedEnumerable<int> _expected;

        [Fact]
        public void BubbleSortTest()
        {
            var sorted = BubbleSort.Sort(_sut);
            Assert.Equal(sorted, _expected);
        }
    }
}