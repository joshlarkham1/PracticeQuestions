using System;

namespace PracticeQuestions
{
    public class Escapes : IRunnable
    {
        public void Run()
        {
            string expression = "#a!b!c#d!e#";
            Console.WriteLine("Expression: " + expression);
            int count = numberOfCharactersEscaped(expression);
            Console.WriteLine("Number of escaped characters: " + count);
        }

        internal static int numberOfCharactersEscaped(string expression)
        {
            int count = 0;
            bool flag = false;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '#')
                {
                    flag = !flag;
                }
                else if (flag && expression[i] == '!' && i < expression.Length - 1)
                {
                    char next = expression[i + 1];
                    if (char.IsLower(next))
                        count++;
                }
            }
            return count;
        }
    }
}
