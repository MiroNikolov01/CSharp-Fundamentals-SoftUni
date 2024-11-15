using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<Day>\d{2})([\/.-])(?<Month>[A-Za-z]{3})\1(?<Year>\d{4})\b";
            var dates = Console.ReadLine();
            MatchCollection matchDates = Regex.Matches(dates, regex);
            foreach (Match date in matchDates)
            {
                var day = date.Groups["Day"].Value;
                var month = date.Groups["Month"].Value;
                var year = date.Groups["Year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
