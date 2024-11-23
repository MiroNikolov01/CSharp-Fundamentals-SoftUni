using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<destination>=[A-Z][A-Za-z]+=|\/[A-Z][A-Za-z]+\/)";
            List<string> destinations = new List<string>();
            string input = Console.ReadLine();
            int travelPoints = 0;
            foreach (Match source in Regex.Matches(input, pattern))
            {
                string destination = source.Value.Trim('/', '=');
                if (destination.Length >= 3)
                {
                    destinations.Add(destination);
                    travelPoints += destination.Length;
                }
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");

        }
    }
}
