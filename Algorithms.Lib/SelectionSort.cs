using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Lib
{
    public static class SelectionSort
    {
        public static IEnumerable<int> Sort(int[] sut)
        {
            var array = sut.ToArray();

            for (var i = 0; i < array.Length; i++)
            {
                var minIndex = i;
                var min = array[minIndex];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        minIndex = j;
                        min = array[minIndex];
                    }
                }

                if (minIndex != i)
                {
                    var tmp = array[i];
                    array[i] = min;
                    array[minIndex] = tmp;
                }
            }

            return array;
        }
    }
}