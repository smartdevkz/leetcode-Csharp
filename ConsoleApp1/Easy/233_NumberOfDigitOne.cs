using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy233
{
    class Solution
    {
        public int CountDigitOne(int n)
        {
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                k += GetCount(i);
            }
            return k;
        }

        private int GetCount(int n)
        {
            int k = 0;
            while (n > 0)
            {
                int r = n % 10;
                if (r == 1) k++;
                n = n / 10;
            }

            return k;
        }
    }
}
