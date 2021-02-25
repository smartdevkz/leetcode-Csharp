using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy258
{
    class Solution
    {
        public int AddDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                var r = num % 10;
                sum += r;
                num = num / 10;
                if (num == 0)
                {
                    num = sum;
                    if (num / 10 == 0) break;
                    sum = 0;
                }
            }
            return num;
        }

    }
}
