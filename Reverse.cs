using System;

namespace PracticeQuestions
{
    public class Reverse : IRunnable
    {
        public void Run()
        {
            string input = "Hello World";
            Console.WriteLine("Input: " + input);
            ReverseString(input);
        }

        internal static void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }

            string reversedString = new string(charArray);
            Console.WriteLine(reversedString);
        }
    }
}
