using System.Linq;
using System;
namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] floatArr = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(float.Parse)
            .ToArray();
            for (int i = 0; i < floatArr.Length; i++)
            {
                Console.WriteLine($"{floatArr[i]} => {(int)Math.Round
                    (floatArr[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
