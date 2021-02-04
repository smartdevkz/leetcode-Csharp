using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy561
{
    public class Solution
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int min = 0;
            for(int i = 0; i < nums.Length; i += 2)
            {
                min += nums[i];
            }
            return min;
        }
    }
}
