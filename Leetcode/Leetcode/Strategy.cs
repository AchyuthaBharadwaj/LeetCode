using Leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Strategy
    {
        private static Dictionary<LeetCode, IProblem> ProblemStrategy;

        public static IProblem GetProblem(LeetCode problem)
        {            
            try
            {
                InitializeStrategy();
                return ProblemStrategy[problem];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void InitializeStrategy()
        {
            ProblemStrategy = new Dictionary<LeetCode, IProblem>
            {
                { LeetCode.Problem_1, new Problem_1() },
                { LeetCode.Problem_2, new Problem_2() },
                { LeetCode.Problem_3, new Problem_3() },
                { LeetCode.Problem_4, new Problem_4() },
                { LeetCode.Problem_5, new Problem_5() },
                { LeetCode.Problem_6, new Problem_6() },
                { LeetCode.Problem_7, new Problem_7() },
                { LeetCode.Problem_8, new Problem_8() },
                { LeetCode.Problem_9, new Problem_9() },
            };
        }
    }
}
