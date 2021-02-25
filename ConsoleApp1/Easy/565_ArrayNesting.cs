using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy565
{
    class Solution
    {
        public int ArrayNesting(int[] nums)
        {
            if (nums == null) return 0;
            int max = 1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if ((nums.Length - i) <= max) break;
                int count = GetCount(nums, i);
                if (max < count) max = count;
            }
            return max;
        }

        int GetCount(int[] nums, int last)
        {
            int k = 0;
            List<int> lst = new List<int>();
            while (nums.Length > last)
            {
                last = nums[last];
                if (lst.Contains(last)) break;
                lst.Add(last);
                k++;
            }
            return k;
        }
    }
}
