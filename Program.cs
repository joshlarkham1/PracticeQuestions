using System;
using System.Linq;
using System.Reflection;
using PracticeQuestions;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var classes = assembly.GetTypes()
                                  .Where(t => t.IsClass && t.Namespace == "PracticeQuestions")
                                  .ToList();

            while (true)
            {
                Console.WriteLine("\n*** ALGORITHM PRACTICE MENU ***\n");
                Console.WriteLine("Please choose an option:\n");

                for (int i = 0; i < classes.Count; i++)
                    Console.WriteLine($"{i + 1}. {classes[i].Name}");

                Console.WriteLine($"{classes.Count + 1}. Exit");

                Console.Write("\nEnter your choice number: ");
                string selected = Console.ReadLine();

                if (int.TryParse(selected, out int choice))
                {
                    if (choice >= 1 && choice <= classes.Count)
                    {
                        Type chosenClass = classes[choice - 1];
                        Console.WriteLine($"\nYou selected: {chosenClass.Name}");

                        object instance = Activator.CreateInstance(chosenClass);

                        if (instance is IRunnable runnable)
                        {
                            runnable.Run();
                        }
                        else
                        {
                            Console.WriteLine("Selected class does not implement IRunnable.");
                        }
                    }
                    else if (choice == classes.Count + 1)
                    {
                        Console.WriteLine("Exiting program...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid choice.");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a number.");
                }
            }
        }
    }
}
