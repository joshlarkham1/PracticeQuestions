using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace PracticeQuestions
{
    public class TwoSum : IRunnable
    {
        public void Run()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            Console.WriteLine("Testing TwoSumBruteForce:");
            int[] bruteForceResult = TwoSumBruteForce(nums, target);
            Console.WriteLine($"Indices: [{bruteForceResult[0]}, {bruteForceResult[1]}]");

            Console.WriteLine("\nTesting TwoSumHashMap:");
            int[] hashMapResult = TwoSumHashMap(nums, target);
            Console.WriteLine($"Indices: [{hashMapResult[0]}, {hashMapResult[1]}]");
        }
        public int[] TwoSumBruteForce(int[] nums, int target)
        {

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                    
                }
            }
            return new int[0];
        }


        public int[] TwoSumHashMap(int[] nums, int target)
        {
            int[] result = new int[2];

            Dictionary<int, int> values = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                int sum = target - nums[i]; // stores the value to be searched

                if (values.ContainsKey(sum)) // check if the value is in the hash
                {
                    result = new int[] { values[sum], i };
                    break;
                }
                values[nums[i]] = i; // assign values after to check for first index
            }
            return result;
        }
    }
}
