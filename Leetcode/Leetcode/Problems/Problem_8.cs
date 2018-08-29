using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class Problem_8 : IProblem
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            var startIndex = 0;
            var endIndex = 0;

            while (str[startIndex] == ' ')
            {
                startIndex++;
            }

            endIndex = startIndex;

            while (endIndex < str.Length &&
                (('0' <= str[endIndex] && str[endIndex] <= '9')
                || (startIndex == endIndex && str[endIndex] == '-')
                || (startIndex == endIndex && str[endIndex] == '+')))
            {
                endIndex++;
            }

            var s = str.Substring(startIndex, endIndex - startIndex);

            try
            {
                return int.Parse(s);
            }
            catch (OverflowException)
            {
                if (s.StartsWith("-"))
                    return int.MinValue;
                else
                    return int.MaxValue;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void ExecuteSolution()
        {
            Console.WriteLine("Output: " + MyAtoi("4193 with words"));
        }
    }
}
