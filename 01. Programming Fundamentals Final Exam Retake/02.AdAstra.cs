using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#|])(?<Name>[A-Za-z ]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>(?:[0-9]|[1-9][0-9]{1,3}|10000))\1";

            bool isHashTag = false;
            bool isOrSymbol = false;
            string input = Console.ReadLine();
            double foodToLast = 0;
            List<Food> output = new List<Food>();
            const int calorieIntake = 2000;
            int sum = 0;

            foreach (Match match in Regex.Matches(input, pattern))
            {
                string foodName = match.Groups["Name"].Value;
                string expirationDate = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);
                sum += calories;
                Food food = new Food(foodName, expirationDate, calories);
                output.Add(food);

            }
            foodToLast = Calculation(sum, calorieIntake);

            Console.WriteLine($"You have food to last you for: {foodToLast} days!");
            foreach (var food in output)
            {
                Console.WriteLine($"Item: {food.Name}, Best before: {food.Date}, Nutrition: {food.Calories}");
            }


        }
        static double Calculation(double sum, int neededIntake)
        {
            double foodToLast = 0;
            sum /= (double)neededIntake;
            if (sum <= 0)
            {
                return 0;
            }
            foodToLast = Math.Floor(sum);
            return foodToLast;
        }
    }
    class Food
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Calories { get; set; }
        public Food(string name, string date, int calories)
        {
            Name = name;
            Date = date;
            Calories = calories;
        }
    }
}
