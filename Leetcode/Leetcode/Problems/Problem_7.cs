using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class Problem_7 : IProblem
    {
        public int Reverse(int x)
        {
            try
            {
                var s = x.ToString();
                bool isNegative = false;
                if (s.StartsWith("-"))
                {
                    isNegative = true;
                    s = s.Substring(1);
                }

                var temp = s.ToCharArray();
                Array.Reverse(temp);
                return int.Parse(isNegative ? "-" + new string(temp) : new string(temp));
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void ExecuteSolution()
        {
            Console.WriteLine("Output: " + Reverse(321));
        }
    }
}
