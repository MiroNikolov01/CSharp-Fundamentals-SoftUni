using System;

namespace _04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            for (int start = 2; start <= end; start++)
            {
                bool isPrime = true;
                for (int division = 2; division < start; division++)
                {
                    if (start % division == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                Console.WriteLine($"{start} -> true");
                }
                else
                {
                Console.WriteLine($"{start} -> false");
                }

            }

        }
    }
}
