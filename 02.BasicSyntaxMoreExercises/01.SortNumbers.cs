using System;
using System.Globalization;
using System.Threading;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double numberThree = double.Parse(Console.ReadLine());
            double maxNumber = Math.Max(numberOne, Math.Max(numberTwo, numberThree));
            double minNumber = Math.Min(numberOne, Math.Min(numberTwo, numberThree));
            double middleNumber = numberOne + numberTwo + numberThree - maxNumber - minNumber;
            Console.WriteLine(maxNumber);
            Console.WriteLine(middleNumber);
            Console.WriteLine(minNumber);

        }
    }
}
