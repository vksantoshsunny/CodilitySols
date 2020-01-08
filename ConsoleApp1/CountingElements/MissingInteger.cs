using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.CountingElements
{
    // you can also use other imports, for example:
    // using System.Collections.Generic;

    // you can write to stdout for debugging purposes, e.g.
    // Console.WriteLine("this is a debug message");

    class MissingInteger
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Dictionary<int, int> map = new Dictionary<int, int>();
            int N = A.Length;

            foreach(var item in A)
            {
                if (map.ContainsKey(item) == false)
                {
                    map.Add(item, item);
                }
            }

            int i = 1;

            do
            {
                if (map.ContainsKey(i) == false)
                {
                    return i;
                }
                i++;

            } while (i <= N);

            return i;

        }
    }

}
