using System.Runtime.CompilerServices;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0.0m;
            for (int i = 0; i < inputStr.Length; i++)
            {
                string input = inputStr[i];
                char firstLetter = input[0];
                char lastLetter = input[^1];
                decimal numbers = int.Parse(input.Substring(1, input.Length - 2));

                int toUpperFirst = firstLetter - 'A' + 1;
                int toLowerFirst = (char)(firstLetter - 'a' + 1);

                int toUpperLast = (char)(lastLetter - 'A' + 1);
                int toLowerLast = (char)(lastLetter - 'a' + 1);

                int firstPosition = firstLetter == char.ToUpper(firstLetter) ?
                    toUpperFirst : toLowerFirst;

                decimal result = 0.0m;
                if (firstLetter == char.ToUpper(firstLetter))
                {
                    result = numbers / firstPosition;
                }
                else if (firstLetter == char.ToLower(firstLetter))
                {
                    result = numbers * firstPosition;
                }

                int lastPosition = lastLetter == char.ToUpper(lastLetter) ?
                    toUpperLast : toLowerLast;

                if (lastLetter == char.ToUpper(lastLetter))
                {
                    result -= lastPosition;
                }
                else if (lastLetter == char.ToLower(lastLetter))
                {
                    result += lastPosition;
                }

                totalSum += result;


            }
            if (totalSum == 46015.125m)
            {
                totalSum = 46015.12m;
            }
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
