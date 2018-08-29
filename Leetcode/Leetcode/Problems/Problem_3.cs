using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class Problem_3 : IProblem
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var list = new List<char>();
                for (int j = i; j < s.Length; j++)
                {
                    if (list.Contains(s[j]))
                    {
                        break;
                    }
                    else
                    {
                        list.Add(s[j]);
                    }
                }
                max = max > list.Count ? max : list.Count;
            }
            return max;
        }

        public void ExecuteSolution()
        {
            Console.WriteLine("Output: " + LengthOfLongestSubstring("abcabcbb"));
        }
    }
}
