using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                string[] chars = new string[arr.Length];
                chars[i] = arr[i];
            }
            Console.WriteLine(string.Join(' ', arr.Reverse()));


        }
    }
}
