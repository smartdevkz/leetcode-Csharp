using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy172
{
    class Solution
    {
        public int TrailingZeroes2(int n)
        {
            if (n < 5) return 0;
            var factorial = GetFactorial(n);
            int k = 0;
            for(int i = factorial.Length - 1; i >=0 ; i--)
            {
                if (factorial[i] == '0')
                {
                    k++;
                }
                else
                {
                    break;
                }
            }
            return k;
        }

        public int TrailingZeroes(int n)
        {
            if (n < 5) return 0;
            int k = 0;
            for(int i = 5; i <= n; i += 5)
            {
                k += GetCount(i);
            }
            return k;
        }

        public int GetCount(int i)
        {
            int k = 0; 
            while (i % 5 == 0)
            {
                k++;
                i = i / 5;
            }
            return k;
        }

        public string GetFactorial(int n)
        {
            if (n == 5) return "120";
            return Multiply(GetFactorial(n - 1), n);
        }

        string Multiply(string s, int k)
        {
            var builder = new StringBuilder();
            int r = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int d = Convert.ToInt32(s[i].ToString());
                int m = d * k + r;
                r = m / 10;
                builder.Insert(0, (m % 10).ToString());
            }
            if (r > 0) builder.Insert(0, r);
            return builder.ToString();
        }
    }
}
