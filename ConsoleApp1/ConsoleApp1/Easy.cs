using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Easy
    {
        //26. Remove Duplicates from Sorted Array
        public int RemoveDuplicates(int[] nums)
        {
            int? prev = null;
            int k = 0;
            foreach (var item in nums)
            {
                if (item != prev)
                {
                    prev = item;
                    nums[k] = item;
                    k++;
                }
            }

            return k;
        }

        //27. Remove Element 83% 13%
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    k++;
                }
                else
                {
                    nums[i - k] = nums[i];
                }
            }
            return nums.Length - k;
        }

        //38. Count and Say
        public string CountAndSay(int n)
        {
            int i = 1;
            string res = "1";
            while (i < n)
            {
                res = getSay(res);
                i++;
            }
            return res;
        }

        public string getSay(string s)
        {
            var stringBuilder = new StringBuilder();
            char prev = s[0];
            int k = 0;
            foreach (var c in s)
            {
                if (c == prev)
                {
                    k++;
                }
                else
                {
                    stringBuilder.Append(k);
                    stringBuilder.Append(prev);
                    prev = c;
                    k = 1;
                }
            }

            stringBuilder.Append(k);
            stringBuilder.Append(prev);

            return stringBuilder.ToString();
        }
    }
}
