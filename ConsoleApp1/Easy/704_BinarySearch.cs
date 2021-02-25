using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy704
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return -1;
            return Find(nums, target, 0, nums.Length - 1);
        }

        private int Find(int[] nums, int target, int start, int end)
        {
            if (end - start <= 1)
            {
                for (int i = start; i <= end; i++)
                {
                    if (nums[i] == target) return i;
                }
                return -1;
            }
            int mid = (end + start) / 2;
            if (nums[mid] < target)
            {
                return Find(nums, target, mid, end);
            }
            else if (nums[mid] == target)
            {
                return mid;
            }
            else
            {
                return Find(nums, target, start, mid);
            }
        }
    }
}
