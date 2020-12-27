using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy268
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            int lastElement = -1;
            int i = 0;
            while (i < nums.Length)
            {
                var val = nums[i];
                if (val < nums.Length)
                {
                    if (i == val || val == -1)
                    {
                        i++;
                        continue;
                    }
                    var t = nums[val];
                    nums[val] = val;
                    nums[i] = t;
                }
                else
                {
                    nums[i] = -1;
                    lastElement = val;
                    i++;
                }
            }

            if (lastElement == -1) return nums.Length;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == -1) return j;
            }
            return -1;
        }
    }
}
