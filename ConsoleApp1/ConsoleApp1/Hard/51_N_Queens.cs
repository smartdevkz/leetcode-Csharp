using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hard51
{
    public class Solution
    {
        public void Run(int n)
        {
            var res = SolveNQueens(n);
            Display(res);
        }

        public IList<IList<string>> SolveNQueens(int n)
        {
            var res = new List<List<string>>();
            var arr = Init(n);
            var lst = GetList(arr, 0, 0);
            while (lst != null)
            {
                res.Add(Convert(lst));
                Display(lst);
                var val = lst[n - 1];
                lst[n - 1] = -1;
                lst = GetList(lst, n - 1, ++val);
            }
            return res.ToArray();
        }

        List<string> Convert(int[] res)
        {
            List<string> lst = new List<string>();
            var builder = new StringBuilder();
            int n = res.Length;
            int i = 0;
            int j = 0;
            while (i < n * n)
            {
                if (j < res.Length && i == res[j])
                {
                    builder.Append("Q");
                    j++;
                }
                else
                {
                    builder.Append(".");
                }
                i++;
                if (i % n == 0)
                {
                    lst.Add(builder.ToString());
                    builder = new StringBuilder();
                }
            }
            return lst;
        }

        int[] Init(int n)
        {
            var lst = new List<int>();
            for (int i = 0; i < n; i++) lst.Add(-1);
            return lst.ToArray();
        }

        int[] GetList(int[] res, int pos, int val)
        {
            int n = res.Length;
            while (pos >= 0 && pos < n)
            {
                //Display(res);
                if (res[0] == 4 && res[1] == 6 && res[2] == 13 && res[3] == 15)
                {
                    var stop = 1;
                }
                val = GetNext(res, val);
                if (val < 0)
                {
                    res[pos] = -1;
                    pos--;
                    if (pos < 0) return null;
                    val = res[pos];
                    val++;
                    res[pos] = -1;
                }
                else
                {
                    res[pos] = val;
                    pos++;
                    val++;
                }
            }
            return res[n - 1] >= 0 ? res : null;
        }

        int GetNext(int[] res, int val)
        {
            int n = res.Length;
            if (val >= n * n) return -1;
            if (isAttacked(res, val))
            {
                val++;
                return GetNext(res, val);
            }
            else
            {
                return val;
            }
        }

        bool isAttacked(int[] res, int val)
        {
            int n = res.Length;
            foreach (var item in res)
            {
                if (item < 0) break;
                int current = item;
                while ((current + 1) % n != 0)
                {
                    if (current == val) return true;
                    current++;
                }

                current = item;
                while (current < n * n && (current+1) % n > 0)
                {
                    if (current == val) return true;
                    current += (n - 1);
                }

                current = item;
                while (current < n * n)
                {
                    if (current == val) return true;
                    current += n;
                }

                current = item;
                while (current < n * n && current % n > 0)
                {
                    if (current == val) return true;
                    current += (n + 1);
                }
            }
            return false;
        }

        void Display(int[] res)
        {
            foreach (var item in res)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        void Display(IList<IList<string>> res)
        {
            foreach (var arr in res)
            {
                foreach (var item in arr)
                {
                    Console.WriteLine(item + " ");
                }
                Console.WriteLine("");
            }
        }

        void Display(IList<IList<int>> res)
        {
            foreach (var arr in res)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
