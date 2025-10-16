using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions
{
    public class AlphabetShift : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Running AlphabetShift example...");

            string input = "abc";
            List<int> rolls = new List<int> { 1, 2, 3 };

            string result = RollTheString(input, rolls);
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Rolls: {string.Join(", ", rolls)}");
            Console.WriteLine($"Result: {result}");
        }

        internal static string RollTheString(string s, List<int> roll)
        {
            int size = s.Length;
            int[] rolls = new int[size];

            foreach (int r in roll)
            {
                if (r <= size)
                {
                    rolls[0] += 1;
                }
                if (r < size)
                {
                    rolls[r] -= 1;
                }
            }

            for (int i = 1; i < size; i++)
            {
                rolls[i] += rolls[i - 1];
            }

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                int shift = rolls[i] % 26;
                char c = s[i];
                char rolled = (char)('a' + (c + shift - 'a') % 26);
                result.Append(rolled);
            }

            return result.ToString();
        }
    }
}
