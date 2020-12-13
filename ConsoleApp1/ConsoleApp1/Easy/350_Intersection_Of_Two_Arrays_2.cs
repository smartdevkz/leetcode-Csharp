using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy350
{
    class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0) return new int[] { };
            if (nums2 == null || nums2.Length == 0) return new int[] { };
            Array.Sort(nums1);
            Array.Sort(nums2);
            if (nums1[0] > nums2[nums2.Length - 1] || nums2[0] > nums1[nums1.Length - 1]) return new int[] { };
            int i = 0, j = 0;
            var lst = new List<int>();
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    lst.Add(nums1[i]);
                    i++; j++;
                }
                else
                {
                    if (nums1[i] > nums2[j])
                        j++;
                    else i++;
                }
            }

            return lst.ToArray();
        }
    }
}
