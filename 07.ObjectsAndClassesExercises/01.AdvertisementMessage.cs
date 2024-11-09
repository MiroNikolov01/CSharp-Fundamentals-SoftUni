
namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] phrase = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int input = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < input; i++)
            {
                int randomPhrase = random.Next(phrase.Length);
                int randomEvents = random.Next(events.Length);
                int randomAuthors = random.Next(authors.Length);
                int randomCities = random.Next(cities.Length);
                Console.WriteLine($"{phrase[randomPhrase]} {events[randomEvents]} {authors[randomAuthors]} – {cities[randomCities]}.");

            }
        }
    }
}










