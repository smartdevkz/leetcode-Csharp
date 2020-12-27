using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy263
{
    class Solution
    {
        public bool IsUgly(int num)
        {
            var arr = new int[] { 2, 3, 5 };
            if (num < 2) return false;
            while (num > 1)
            {
                bool isDivided = false;
                foreach (var item in arr)
                {
                    if (num % item == 0)
                    {
                        num = num / item;
                        isDivided = true;
                    }
                }

                if (!isDivided) break;
            }
            return num == 1;
        }
    }
}
