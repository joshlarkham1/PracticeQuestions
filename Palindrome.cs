using System;

namespace PracticeQuestions
{
    public class Palindrome : IRunnable
    {
        public void Run()
        {
            string input = "radar";
            Console.WriteLine("Input: " + input);
            palindromeCheck(input);
        }

        internal static void palindromeCheck(string str)
        {
            bool flag = false;

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = true;
                    break;
                }
            }

            Console.WriteLine(flag ? "Not a Palindrome!" : "Palindrome!");
        }
    }
}
