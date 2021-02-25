using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy645
{
    public class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            Array.Sort(nums);
            int needed = -1;
            if (nums[nums.Length - 1] < nums.Length) needed = nums.Length;
            if (nums[0] != 1) needed = 1;
            int repeated = -1;
            for (int i = 1; i < nums.Length; i++)
            {
                int d = nums[i] - nums[i - 1];
                if (needed == -1 && d > 1)
                {
                    needed = nums[i]-1;
                }
                if (repeated == -1 && d == 0)
                {
                    repeated = nums[i];
                }
                if (needed >= 0 && repeated >= 0) break;
            }
            return new int[] { repeated, needed };
        }
    }
}
