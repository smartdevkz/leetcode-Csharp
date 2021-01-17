using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1037
{
    public class Solution
    {
        public bool IsBoomerang(int[][] points)
        {
            var x1 = points[0][0];
            var y1 = points[0][1];

            var x2 = points[1][0];
            var y2 = points[1][1];

            var x3 = points[2][0];
            var y3 = points[2][1];

            return (y2 - y3) * (x1 - x3) - (y1 - y3) * (x2 - x3) == 0;
        }
    }
}
