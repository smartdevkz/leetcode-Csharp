using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy970
{
    public class Solution
    {
        public IList<int> PowerfulIntegers(int x, int y, int bound)
        {
            var res = new HashSet<int>();

            double val = 0;

            for (var i = 0; val < bound; i++)
            {
                for (var j = 0; val < bound; j++)
                {
                    val = Math.Pow(x, i) + Math.Pow(y, j);

                    if (val <= bound) res.Add((int)val);

                    if (y == 1) break;
                }

                if (x == 1) break;

                val = Math.Pow(x, i);
            }

            return res.ToList();
        }
    }
}
