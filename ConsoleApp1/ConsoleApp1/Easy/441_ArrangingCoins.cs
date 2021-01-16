using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy441
{
    public class Solution
    {
        public int ArrangeCoins(int n)
        {
            int k = 0;
            while (n >= 0)
            {
                k++;
                n -= k;
            }
            return k - 1;
        }
    }
}
