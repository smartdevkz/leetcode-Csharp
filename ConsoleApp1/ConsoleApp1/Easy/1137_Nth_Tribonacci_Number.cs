using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1137
{
    public class Solution
    {
        public int Tribonacci(int n)
        {
            int a = 0, b = 1, c = 1;
            for(int i = 3; i <= n; i++)
            {
                int newA = b;
                int newB = c;
                c = a + b + c;
                a = newA;
                b = newB;
            }
            return c;
        }
    }
}
