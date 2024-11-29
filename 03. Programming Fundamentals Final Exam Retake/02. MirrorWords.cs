using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
            string input = Console.ReadLine();
            Dictionary<string, string> pairsMap = new Dictionary<string, string>();
            int mirrorPairs = 0;
            int foundPairs = 0;
            foreach (Match match in Regex.Matches(input, pattern))
            {
                string wordOne = match.Groups["first"].Value;
                string wordTwo = match.Groups["second"].Value;
                if (IsMirror(wordOne,wordTwo))
                {
                    mirrorPairs++;
                    pairsMap[wordOne] = wordTwo;
                }
                foundPairs++;
            }
            if (foundPairs == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{foundPairs} word pairs found!");
            }
            if (mirrorPairs > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", pairsMap.Select(pair => $"{pair.Key} <=> {pair.Value}")));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
        static bool IsMirror(string wordOne, string wordTwo)
        {
            return wordOne == new string(wordTwo.Reverse().ToArray());
        }
    }
}
