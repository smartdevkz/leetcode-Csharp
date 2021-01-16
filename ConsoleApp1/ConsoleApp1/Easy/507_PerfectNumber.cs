using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy507
{
    public class Solution
    {
        public bool CheckPerfectNumber(int num)
        {
            if (num == 1) return false;
            int r = (int)Math.Sqrt(num);
            int sum = 1;
            for(int a = 2; a <= r; a++)
            {
                if (num % a == 0)
                {
                    sum += a;
                    var b = num / a;
                    if (a != b) sum += b;
                }
            }
            return sum == num;
        }
    }
}
