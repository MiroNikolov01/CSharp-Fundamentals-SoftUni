namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();
            foreach (string word in words)
            {
                string toLowerCase = word.ToLower();
                if (!counts.ContainsKey(toLowerCase))
                {
                    counts.Add(toLowerCase, 1);
                }
                else
                {
                    counts[toLowerCase]++;
                }
            }
            foreach (KeyValuePair<string, int> count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}



