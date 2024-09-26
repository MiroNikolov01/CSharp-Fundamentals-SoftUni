using System;
using System.Linq;

namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            Console.Write(string.Join(" ",numbers.Reverse()));
        }
    }
}
