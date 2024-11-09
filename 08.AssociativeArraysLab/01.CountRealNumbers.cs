
namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            foreach (int num in numbers)
            {
                if (!counts.ContainsKey(num))
                {
                    counts.Add(num, 1);
                }
                else
                {
                    counts[num]++;
                }

            }
            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }

        }
    }
}




