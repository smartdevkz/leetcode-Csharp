using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy509
{
    public class Solution
    {
        public int Fib(int n)
        {
            if (n <= 1) return n;
            int a = 0, b = 1;
            for(int i = 2; i <= n; i++)
            {
                int c = b;
                b = a + b;
                a = c;
            }
            return b;
        }

        /*
         * 52ms, 15.4mb
         Solution 1

        public int Fib(int n)
        {
            if (n <= 1) return n;
            return Fib(n-1)+Fib(n-2);
        }
         */
    }
}
