using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int numberCopy = number;
            while (numberCopy > 0)
            {
                int digit = numberCopy % 10;
                numberCopy /= 10;
                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;

            }
            bool strongNumber = sum == number;
            Console.WriteLine(strongNumber ? "yes" : "no");

        }
    }
}
