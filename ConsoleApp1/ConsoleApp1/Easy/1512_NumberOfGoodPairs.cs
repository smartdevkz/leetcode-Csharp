using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1512
{
    class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            if (nums.Length < 2) return 0;
            int k = 0;
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j]) k++;
                }
            }
            return k;
        }
    }
}
