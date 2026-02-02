using System;
using System.Collections.Generic;
using System.IO;

namespace ProgrammingTestTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Programming Test: Combined Tasks ===");
                Console.WriteLine("1. Divisibility Check (3 or 5) & Sum");
                Console.WriteLine("2. Generate Fibonacci");
                Console.WriteLine("3. Exit");
                Console.Write("\nSelect an option (1-3): ");

                switch (Console.ReadLine())
                {
                    case "1":
                        RunDivisibilityTask();
                        break;
                    case "2":
                        RunFibonacciTask();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void RunDivisibilityTask()
        {
            Console.Clear();
            Console.WriteLine("--- Divisibility Task ---");
            Console.Write("Enter an integer: ");
            int end = int.Parse(Console.ReadLine());

            int sum = 0;
            List<int> matches = new List<int>();

            for (int i = 0; i <= end; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    matches.Add(i);
                    sum += i;
                }
            }

            Console.WriteLine("\nMatching Numbers: " + string.Join(", ", matches));
            Console.WriteLine($"Total Sum: {sum}");
            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunFibonacciTask()
        {
            Console.Clear();
            Console.WriteLine("--- Fibonacci Task ---");            
            long n1 = 0, n2 = 1; // Using 'long' for larger numbers
            List<long> matches = new List<long>();
            try
            {            
                for (int i = 0; i < 15; i++)
                {
                    matches.Add(n1);
                    long next = n1 + n2;
                    n1 = n2;
                    n2 = next;  
                }
                
                Console.WriteLine("\n" + string.Join(", ", matches));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}