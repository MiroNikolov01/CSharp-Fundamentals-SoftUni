using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 1 || n == 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    return;
                }

            }

        }
    }
}
