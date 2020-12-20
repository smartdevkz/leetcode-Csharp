using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy204
{
    class Solution
    {
        public int CountPrimes(int n)
        {
            if (n < 3) return 0;
            if (n == 3) return 1;
            int k = 1;
            for (int i = 3; i < n; i += 2)
            {
                if (IsPrime(i)) k++;
            }
            return k;
        }

        private bool IsPrime(int n)
        {
            if (n < 4) return true;
            if (n % 2 == 0) return false;
            int i = 3;
            while (i * i <= n)
            {
                if (n % i == 0) return false;
                i += 2;
            }
            return true;
        }
    }
}
