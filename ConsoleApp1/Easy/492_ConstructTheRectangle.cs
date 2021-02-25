using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy492
{
    public class Solution
    {
        public int[] ConstructRectangle(int area)
        {
            var r = (int)Math.Sqrt(area);
            for(int i = r; i >= 1; i--)
            {
                if (area % i == 0) return new int[] { area / i, i };
            }
            return null;
        }
    }
}
