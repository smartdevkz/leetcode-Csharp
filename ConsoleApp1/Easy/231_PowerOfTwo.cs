using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy231
{
    public class Solution
    {
        //rt:51.63%, m:6.5%
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0) return false;
            return Convert.ToString(n, 2).Count(x => x == '1') == 1;
        }

        //rt:97.15%, m:74.80%
        public bool IsPowerOfTwo2(int n)
        {
            if (n <= 0) return false;
            while (n % 2 == 0 && n != 1)
            {
                n = n / 2;
            }
            return n == 1;
        }

        //rt:80.49%, m:74.80%
        public bool IsPowerOfTwo3(int n)
        {
            return n>0&&(n & (n - 1)) == 1;
        }
    }
}
