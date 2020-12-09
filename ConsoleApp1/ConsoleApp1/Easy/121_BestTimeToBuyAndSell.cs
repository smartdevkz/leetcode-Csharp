using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy121
{
    class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int n = prices.Count();
            if (n == 0 || n == 1) return 0;

            int max = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (prices[i] >= prices[j]) continue;
                    int diff = prices[j] - prices[i];
                    if (diff > max) max = diff;
                }
            }
            return max;
        }
    }
}
