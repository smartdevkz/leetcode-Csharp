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
            int i = 0, j = i + 1;
            while (i < nums.Length - 1)
            {
                if (nums[i] != nums[j])
                {
                    if (j - i >= k)
                    {
                        i++;
                        j = i;
                    }
                    if (j < nums.Length - 1)
                    {
                        j++;
                    }
                    else { i++; }
                        
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
