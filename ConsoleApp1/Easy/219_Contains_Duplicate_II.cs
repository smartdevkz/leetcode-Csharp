using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy219
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            if (k == 0) return false;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    int d = i - dict[nums[i]];
                    if (d <= k) return true;
                    dict[nums[i]] = i;
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }
            return false;
        }
    }
}
