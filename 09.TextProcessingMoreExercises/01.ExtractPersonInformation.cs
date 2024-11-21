using System.Text.RegularExpressions;

namespace _01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternName = @"(?<name>@[A-Z-a-z]+\|)";
            string patternAge = @"(?<age>#\d+\*)";
            int countInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < countInput; i++)
            {
                string input = Console.ReadLine();

                string name = Regex.Match(input, patternName).Groups["name"].Value.Trim('@', '|');

                int age = int.Parse(Regex.Match(input, patternAge).Groups["age"].Value.Trim('#').Trim('*'));

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
