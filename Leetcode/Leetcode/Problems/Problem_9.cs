using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class Problem_9 : IProblem
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            var c = x.ToString();
            var chararray = c.ToCharArray();
            Array.Reverse(chararray);
            var cRev = new string(chararray);
            if (c.Equals(cRev))
                return true;
            else
                return false;
        }

        public void ExecuteSolution()
        {
            Console.WriteLine("Output: " + IsPalindrome(12321));
        }
    }
}
