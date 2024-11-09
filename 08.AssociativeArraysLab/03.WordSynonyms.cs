namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictWords = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!dictWords.ContainsKey(word))
                {
                    dictWords.Add(word, new List<string>());
                }
                dictWords[word].Add(synonym);
            }
            foreach (var words in dictWords)
            {
                Console.WriteLine($"{words.Key} - {string.Join(", ", words.Value)}");
            }
        }
    }
}