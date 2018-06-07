using System.Linq;
using Algorithms.Lib;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
    public class SortingTests
    {
        public SortingTests()
        {
            _sut = new[] {4, 1, 3, 2, 4, 7, 9, 50, 1, 74, 200, 30, 4, 7};
            _expected = _sut.OrderBy(x => x);
        }

        private readonly int[] _sut;
        private readonly IOrderedEnumerable<int> _expected;

        [Fact]
        public void QuickSortTest()
        {
            var sorted = QuickSort.Sort(_sut);
            sorted.Should().ContainInOrder(_expected);
        }

        [Fact]
        public void SelectionSortTest()
        {
            var sorted = SelectionSort.Sort(_sut);
            sorted.Should().ContainInOrder(_expected);
        }

        [Fact]
        public void BubbleSortTest()
        {
            var sorted = BubbleSort.Sort(_sut);
            sorted.Should().ContainInOrder(_expected);
        }

        [Fact]
        public void InsertionSortTest()
        {
            var sorted = InsertionSort.Sort(_sut);
            sorted.Should().ContainInOrder(_expected);
        }
    }
}