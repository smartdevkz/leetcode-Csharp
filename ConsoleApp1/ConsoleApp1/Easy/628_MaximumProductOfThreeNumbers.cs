using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy628
{
    public class Solution
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int max= nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3];
            if (nums.Length > 2 && nums[0] < 0 && nums[1] < 0)
            {
                int max2 = nums[nums.Length - 1] * nums[0] * nums[1];
                if (max2 > max) return max2;
            }
            return max;
        }
    }
}
