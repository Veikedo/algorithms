using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Lib
{
  public static class StringPermutations
  {
    public static IEnumerable<string> Find(string small, string big)
    {
      var dictionary = small
        .GroupBy(x => x)
        .ToDictionary(x => x.Key, x => x.Count());

      for (var i = 0; i <= big.Length - small.Length; i++)
      {
        var key = big[i];
        if (dictionary.ContainsKey(key))
        {
          var ints = dictionary.ToDictionary(x => x.Key, x => x.Value);
          ints[key]--;

          for (int j = i + 1; j < small.Length; j++)
          {
            if (!ints.ContainsKey(big[j]))
            {
              break;
            }
          }
        }
      }
    }
  }
}