using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy1002
{
    class Solution
    {
        public IList<string> CommonChars(string[] A)
        {
            if (A.Length == 0 || A == null) return Empty();
            if (A.Length == 1) return GetArray(A[0]);
            if (A.Length == 2) return GetIntersection(A[0], A[1]);
            var lst = GetIntersection(A[0], A[1]);
            if (lst.Count == 0) return lst;
            for (int i = 2; i < A.Length; i++)
            {
                GetIntersection(ref lst, A[i]);
                if (lst.Count == 0) break;
            }
            return lst;
        }

        List<string> GetIntersection(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) return new List<string>();
            var lst = new List<String>();
            foreach (var item in s1)
            {
                var i = s2.IndexOf(item);
                if (i > -1)
                {
                    s2 = s2.Remove(i, 1);
                    lst.Add(item.ToString());
                }
            }
            return lst;
        }

        void GetIntersection(ref List<String> lst, string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                lst = new List<string>();
                return;
            }
            int j = 0;
            while (j < lst.Count())
            {

                var i = s.IndexOf(lst[j]);
                if (i > -1)
                {
                    s = s.Remove(i, 1);
                    j++;
                }
                else
                {
                    lst.RemoveAt(j);
                }
            }


        }

        IList<string> Empty()
        {
            return new string[] { };
        }

        public IList<string> GetArray(string s)
        {
            var arr = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = s[i].ToString();
            }
            return arr;
        }
    }
}
