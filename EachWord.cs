using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQuestions
{
    public class EachWord : IRunnable
    {
        public void Run()
        {
            string input = "Hello World from CSharp";
            Console.WriteLine("Original: " + input);
            Console.Write("Reversed words: ");
            reverseEachWord(input);
        }

        internal static void reverseEachWord(string str)
        {
            StringBuilder output = new StringBuilder();
            List<char> chars = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (i == str.Length - 1 && str[i] != ' ')
                        chars.Add(str[i]);

                    for (int j = chars.Count - 1; j >= 0; j--)
                        output.Append(chars[j]);

                    output.Append(' ');
                    chars.Clear();
                }
                else
                {
                    chars.Add(str[i]);
                }
            }

            Console.WriteLine(output.ToString().TrimEnd());
        }
    }
}
