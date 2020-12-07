using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sometasks
{
    class Solution
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

        #region 58. Length of Last Word
        public int LengthOfLastWord(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            int len = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    len++;
                }
                else
                {
                    if (len > 0) break;
                }
            }
            return len;
        }

        #endregion

        #region 66. Plus One
        public int[] PlusOne(int[] digits)
        {
            int r = 1;
            int i = digits.Count() - 1;
            while (r != 0 && i >= 0)
            {
                int sum = digits[i] + r;
                digits[i] = sum % 10;
                r = sum / 10;
                i--;
            }
            if (r > 0)
            {
                var lst = new List<int>() { r };
                lst.AddRange(digits);
                return lst.ToArray();
            }
            return digits;
        }
        #endregion

        #region 69. Sqrt(x)
        public int MySqrt(int x)
        {
            if (x < 2) return x;
            if (x / 2 < 2) return 1;
            int i;
            for (i = 2; i <= (x / 2); i++)
            {
                if ((x / i) < i) break;
            }
            return i - 1;
        }
        #endregion

        #region 88. Merge Sorted Array
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            while (i >= 0 || j >= 0)
            {
                if (i >= 0 && j >= 0)
                    if (nums1[i] <= nums2[j])
                    {
                        nums1[i + j + 1] = nums2[j];
                        j--;
                    }
                    else
                    {
                        nums1[i + j + 1] = nums1[i];
                        i--;
                    }
                else
                {
                    if (j >= 0)
                    {
                        nums1[j] = nums2[j];
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            var arr = nums1;
        }
        #endregion

        #region 118. Pascal's Triangle
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> res = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                if (res.Count() == 0) res.Add(new int[] { 1 });
                else if (res.Count() == 1)
                {
                    res.Add(new int[] { 1, 1 });
                }
                else
                {
                    var children = new int[i + 1];
                    children[0] = 1;
                    var last = res[i - 1];
                    for (int j = 1; j < last.Count(); j++)
                    {

                        children[j] = last[j - 1] + last[j];
                    }
                    children[children.Length - 1] = 1;
                    res.Add(children);
                }
            }
            return res;
        }
        #endregion
    }
}
