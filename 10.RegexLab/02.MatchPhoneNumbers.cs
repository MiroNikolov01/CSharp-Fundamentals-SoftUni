using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patter = @"\+359 2 (\d{3}) (\d{4})|\+359-2-(\d{3})-(\d{4})\b";
            string phoneNumbers = Console.ReadLine();
            Regex regex = new Regex(patter);
            MatchCollection numbers = regex.Matches(phoneNumbers);
           
            var matchedNumbers = numbers.Cast<Match>()
                .Select(m => m.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ",matchedNumbers));
        }
    }
}
