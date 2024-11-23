namespace _03.greaterNumbers
{
    class Program
    {
        static void Main(string[] args)

        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            double sum = sequence.Sum();
            double avarageNumber = sum / sequence.Count;
            List<int> greaterNumbers = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] > avarageNumber)
                {
                    greaterNumbers.Add(sequence[i]);
                }
            }
            greaterNumbers.Sort();
            greaterNumbers.Reverse();
            if (greaterNumbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            if (greaterNumbers.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(greaterNumbers[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", greaterNumbers));
            }
        }
    }
}






