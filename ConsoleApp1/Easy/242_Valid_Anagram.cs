using System;
using System.Collections;

namespace ConsoleApp1.Easy242
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            
            if(s==null||t==null)return s==null&&t==null;
            if (s.Length != t.Length) return false;
            
            var ht = new Hashtable();
            for (int i = 0; i < s.Length; i++)
            {
                if (ht.Contains(s[i]))
                {
                    int count = Convert.ToInt32(ht[s[i]]);
                    ht[s[i]] = ++count;
                }
                else
                {
                    ht.Add(s[i], 1);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (ht.Contains(t[i]))
                {
                    int count = Convert.ToInt32(ht[t[i]]);
                    count--;
                    if (count < 0) return false;
                    ht[t[i]] = count;

                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}