using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class Problem_5 : IProblem
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 0) return "";
            if (s.Length == 1) return s;

            var maxlen = 0;
            bool[,] dp = new bool[s.Length, s.Length];
            var startIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (s[i] == s[j])
                    {
                        var pLength = i - j + 1;
                        if (pLength <= 2 || dp[i - 1, j + 1])
                        {
                            dp[i, j] = true;
                            if (pLength > maxlen)
                            {
                                maxlen = pLength;
                                startIndex = j;
                            }
                        }
                    }
                }
            }

            return s.Substring(startIndex, maxlen);
        }

        public void ExecuteSolution()
        {
            Console.WriteLine("Output: " + LongestPalindrome("babad"));
        }
    }
}
