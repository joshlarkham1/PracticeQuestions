using System;
using System.Collections.Generic;

namespace PracticeQuestions
{
    internal class WordMerge : IRunnable
    {
        public void Run()
        {
            string word1 = "abc";
            string word2 = "pqr";
            Console.WriteLine($"Input: \"{word1}\", \"{word2}\"");
            string result = MergeAlternately(word1, word2);
            Console.WriteLine("Output: " + result);
        }

        public string MergeAlternately(string word1, string word2)
        {
            int A = word1.Length;
            int B = word2.Length;
            int a = 0;
            int b = 0;
            int word = 1;
            var result = new List<char>();

            while (a < A && b < B)
            {
                if (word == 1)
                {
                    result.Add(word1[a]);
                    a++;
                    word = 2;
                }
                else
                {
                    result.Add(word2[b]);
                    b++;
                    word = 1;
                }
            }
            while (a < A)
            {
                result.Add(word1[a]);
                a++;
            }
            while (b < B)
            {
                result.Add(word2[b]);
                b++;
            }
            return new string(result.ToArray());
        }
    }
}
