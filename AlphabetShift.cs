using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions
{
    public class AlphabetShift : IRunnable
    {
        public void Run()
        {
            string input = "abc";
            List<int> rolls = new List<int> { 1, 2, 3 };

            string result = StringRoll(input, new List<int>(rolls));
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Rolls: {string.Join(", ", rolls)}");
            Console.WriteLine($"Result using StringRoll: {result}");
        }

        internal static string StringRoll(string s, List<int> roll)
        {
            for (int i = roll.Count - 2; i >= 0; i--)
            {
                roll[i] = (roll[i] + roll[i + 1]) % 26;
            }

            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)((chars[i] - 'a' + roll[i] % 26) % 26 + 'a');
            }

            return new string(chars);
        }
    }
}
