using System;
using System.Collections.Generic;

namespace PracticeQuestions
{
    public class Occurence : IRunnable
    {
        public void Run()
        {
            string input = "hello world";
            Console.WriteLine("Input: " + input);
            OccurenceCheck(input);
        }

        internal static void OccurenceCheck(string str)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (var c in str)
            {
                if (c != ' ')
                {
                    if (!count.ContainsKey(c))
                        count.Add(c, 1);
                    else
                        count[c]++;
                }
            }

            foreach (var c in count)
                Console.WriteLine("{0} - {1}", c.Key, c.Value);
        }
    }
}
