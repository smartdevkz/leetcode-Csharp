using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy190
{
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            var power = 31;
            uint answer = 0;
            while (n != 0)
            { // check n > 0 is better than check power >= 0
                answer += ((n & 1) << power);
                power--;
                n >>= 1;
            }
            Console.WriteLine(Convert.ToString(answer, 2));
            return answer;
        }
    }
}
