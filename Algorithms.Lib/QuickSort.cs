using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Lib
{
    public static class QuickSort
    {
        public static IEnumerable<int> Sort(int[] sut)
        {
            if (sut.Length == 0)
            {
                return sut;
            }

            if (sut.Length == 1)
            {
                return sut;
            }

            var pivot = sut.First();
            var (lt, gte) = sut.Skip(1).Partition(x => x < pivot);

            return Sort(lt)
                .Concat(new[] {pivot})
                .Concat(Sort(gte));
        }

        public static (TSource[] lt, TSource[] gte) Partition<TSource>(
            this IEnumerable<TSource> src, Func<TSource, bool> key
        )
        {
            var lookup = src.ToLookup(key);
            return (lookup[true].ToArray(), lookup[false].ToArray());
        }
    }
}