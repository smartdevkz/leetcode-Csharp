using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1009
{
    public class Solution
    {
        public int BitwiseComplement(int N)
        {
            if (N == 0) return 0;
            var str = Convert.ToString(N, 2);
            var builder = new StringBuilder();
            foreach (var c in str)
            {
                builder.Append(c == '0' ? '1' : '0');
            }
            return Convert.ToInt32(builder.ToString(), 2);
        }
    }
}
