using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class Problem_1 : IProblem
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (dict.ContainsKey(diff))
                {
                    return new int[] { dict[diff], i };
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }
            return null;
        }

        public void ExecuteSolution()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(nums, target);
            Console.WriteLine("Output: ");
            for(int i=0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
