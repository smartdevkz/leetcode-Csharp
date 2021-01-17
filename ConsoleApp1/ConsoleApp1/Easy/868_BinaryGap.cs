using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy868
{
    public class Solution
    {
        public int BinaryGap(int n)
        {
            var str = Convert.ToString(n, 2);
            int max = 0;
            bool hasStarted = false;
            int d = 0;
            foreach(var c in str)
            {
                if (c == '1')
                {
                    if (hasStarted)
                    {
                        d++;
                        if (d > max) max = d;
                        d = 0;
                    }
                    else
                    {
                        hasStarted = true;
                    }
                }
                else
                {
                    if (hasStarted)
                    {
                        d++;
                    }
                }
            }
            return max;
        }
    }
}
