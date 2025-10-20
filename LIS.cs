using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    internal class LIS : IRunnable
    {
        public void Run()
        {
            int[] input = { 0, 2, 3, 1, 6, 3, 6, 4, 7, 8 };

            Console.WriteLine("Input: [" + string.Join(", ", input) + "]");
            int result = LengthOfLIS(input);
            Console.WriteLine("Length of Longest Increasing Subsequence: " + result);
        }

        public int LengthOfLIS(int[] nums)
        {
            int[] dp = new int[nums.Length];

            int count = 1;

            for (int n = 0; n < nums.Length; n++)
            {
                dp[n] = 1;
            }
            for (int j = nums.Length - 2; j >= 0; j--)
            {
                for (int i = j + 1; i < nums.Length; i++)
                {

                    if (nums[j] < nums[i])
                    {
                        dp[j] = Math.Max(dp[j], 1 + dp[i]);
                    }
                }
            }
            foreach (int value in dp)
            {
                count = Math.Max(count, value);
            }
            return count;
        }
    }
}
