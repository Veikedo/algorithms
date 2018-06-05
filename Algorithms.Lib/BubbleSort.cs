using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Lib
{
    public static class BubbleSort
    {
        public static IReadOnlyList<int> Sort(int[] src)
        {
            var arr = src.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }
    }
}