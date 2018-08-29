using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class Problem_6 : IProblem
    {
        public string Convert(string s, int numRows)
        {
            if (string.IsNullOrWhiteSpace(s) || numRows < 2)
            {
                return s;
            }

            string[] array = new string[numRows];
            var index = -1;
            var direction = 1;

            for (int i = 0; i < s.Length; i++)
            {
                index += direction;
                if (index < 0)
                {
                    index = 1;
                    direction *= -1;
                }
                if (index == numRows)
                {
                    index = numRows - 2;
                    direction *= -1;
                }

                array[index] += s[i];
            }

            return String.Join("", array);
        }

        public void ExecuteSolution()
        {
            Console.WriteLine("Output: " + Convert("PAYPALISHIRING", 4));
        }
    }
}
