using System.Linq;
using System;

namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
            {
                int[] numbers = new int[arr.Length];
                numbers[i] = int.Parse(arr[i]);
            }
            int isEven = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                isEven = 0;
                isEven += int.Parse(arr[i]);
                if (isEven % 2 == 0)
                {
                    sum += isEven;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
