using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy349
{
    class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums1.Length == 0 && nums2 != null) return nums2;
            if (nums2 == null || nums2.Length == 0 && nums1 != null) return nums1;
            return nums1.Length < nums2.Length ? GetIntersection(nums1, nums2) : GetIntersection(nums2, nums1);
        }

        public int[] GetIntersection(int[] a, int[] b)
        {
            var lst = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (lst.Contains(a[i])) continue;
                if (b.Contains(a[i])) lst.Add(a[i]);
            }
            return lst.ToArray();
        }
    }
}
