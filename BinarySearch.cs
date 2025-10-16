using System;

namespace PracticeQuestions
{
    public class SearchAlgorithms : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Running Binary Search example...");

            int[] array = { 1, 3, 5, 7, 9, 11 };
            int target = 7;

            int index = BinarySearch(array, target);

            Console.WriteLine($"Array: {string.Join(", ", array)}");
            Console.WriteLine($"Target: {target}");
            Console.WriteLine(index != -1
                ? $"Target found at index {index}"
                : "Target not found");
        }

        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else if (array[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
