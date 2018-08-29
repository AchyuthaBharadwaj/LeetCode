using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = Strategy.GetProblem(LeetCode.Problem_9);
            problem.ExecuteSolution();
            Console.Read();
        }
    }
}
