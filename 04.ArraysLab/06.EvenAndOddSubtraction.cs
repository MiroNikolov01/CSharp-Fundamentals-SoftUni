﻿using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = 0;
                currentNum = numbers[i];
                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;

                }
            }
            int result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
