using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace _02.LostArtifacts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[\*\^](?<Name>[A-Za-z ]{6,})[\*\^][\+!]+(?<coordinates>-?\d{1,3}(?:\.\d+)?,-?\d{1,3}(?:\.\d+)?)[\+!]+";
            string input = Console.ReadLine();
            bool isValid = default;
        
            foreach (Match match in Regex.Matches(input,pattern))
            {
                string name = match.Groups["Name"].Value;
                string coordinates = match.Groups["coordinates"].Value;
                Console.WriteLine($"Found {name} at coordinates {coordinates}.");
                isValid = true;
            }
            if (!isValid)
            {
                Console.WriteLine("No valid artifacts found.");
            }

        }
    }
}
