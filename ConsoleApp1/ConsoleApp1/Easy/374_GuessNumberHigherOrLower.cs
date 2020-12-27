using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy374
{
    class Solution : GuessGame
    {
        public int GuessNumber(int n)
        {
            int low = 1;
            int high = n;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int res = guess(mid);
                if (res == 0)
                    return mid;
                else if (res < 0)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }
    }

    class GuessGame
    {
        public int guess(int n)
        {
            int pick = 1;
            if (n < pick)
            {
                return -1;
            }
            else if (n > pick)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
