using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Lib
{
    public static class BubbleSort
    {
        public static IReadOnlyList<int> Sort(int[] src)
        {
            var number = src.ToArray();

            var flag = true;
            for (int i = 1; i <= number.Length - 1 && flag; i++)
            {
                flag = false;
                for (int j = 0; j < number.Length - 1; j++)
                {
                    if (number[j + 1] < number[j])
                    {
                        var temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            return number;
        }
    }
}