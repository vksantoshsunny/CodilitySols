using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.CountingElements
{
    using System;
    // you can also use other imports, for example:
    // using System.Collections.Generic;

    // you can write to stdout for debugging purposes, e.g.
    // Console.WriteLine("this is a debug message");

    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int n = A.Length;
            int expectedSum = (n * (n + 1)) / 2;
            int sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach(var item in A)
            {
               if( map.ContainsKey(item){
                    return 0;
                }
                else
                {
                    map.Add(item,item);
                }
                sum = sum + item;
            }

            if(sum == expectedSum)
            {
                return 1;
            }

            return 0;


        }
    }
}
