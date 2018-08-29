using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class Problem_4 : IProblem
    {
        /// <summary>
        /// This is wrong soln. its complexity is O(m+n). still have to optimize to O(log(m+n)).
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = 0;
            int n = 0;
            var sortedList = new List<int>();
            while (m < nums1.Length || n < nums2.Length)
            {
                if (m < nums1.Length && n < nums2.Length)
                {
                    if (nums1[m] < nums2[n])
                    {
                        sortedList.Add(nums1[m]);
                        m++;

                    }
                    else
                    {
                        sortedList.Add(nums2[n]);
                        n++;
                    }
                }
                else if (m < nums1.Length)
                {
                    sortedList.Add(nums1[m]);
                    m++;
                }
                else if (n < nums2.Length)
                {
                    sortedList.Add(nums2[n]);
                    n++;
                }
            }
            var total = sortedList.Count;
            if (total % 2 != 0)
                return sortedList[total / 2];
            else
            {
                total /= 2;
                return (sortedList[total] + sortedList[total - 1]) / 2.0;
            }
        }

        public void ExecuteSolution()
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            Console.WriteLine("Output: " + FindMedianSortedArrays(nums1, nums2));
        }
    }
}
