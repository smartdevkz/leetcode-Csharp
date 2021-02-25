using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy191
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            int k = 0;
            while (n != 0)
            {
                var r= n & 1;
                if ((n & 1) == 1) k++;
                Console.WriteLine(r);
                n >>= 1;
            }
            return k;
        }
    }
}
