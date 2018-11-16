using System;
using System.IO;
using System.Linq;
using Algorithms.Lib;
using FluentAssertions;
using Xunit;

namespace Algorithms.Tests
{
  public class SortingTests
  {
    static SortingTests()
    {
      Sut = File
        .ReadAllBytes("rand.bin")
        .Select(Convert.ToInt32)
        .ToArray();
      Expected = Sut.OrderBy(x => x).ToArray();
    }

    private static readonly int[] Sut;
    private static readonly int[] Expected;

    [Fact]
    public void BubbleSortTest()
    {
      var sorted = BubbleSort.Sort(Sut);
      sorted.Should().ContainInOrder(Expected);
    }

    [Fact]
    public void InsertionSortTest()
    {
      var sorted = InsertionSort.Sort(Sut);
      sorted.Should().ContainInOrder(Expected);
    }

    [Fact]
    public void LinqOrderBySortTest()
    {
      var sorted = Sut.OrderBy(x => x).ToList();
      sorted.Should().ContainInOrder(Expected);
    }

    [Fact]
    public void QuickSortTest()
    {
      var sorted = QuickSort.Sort(Sut);
      sorted.Should().ContainInOrder(Expected);
    }

    [Fact]
    public void SelectionSortTest()
    {
      var sorted = SelectionSort.Sort(Sut);
      sorted.Should().ContainInOrder(Expected);
    }
  }
}