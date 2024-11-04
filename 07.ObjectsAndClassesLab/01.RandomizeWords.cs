namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int position = rnd.Next(words.Length);
                string word = words[i];
                words[i] = words[position];
                words[position] = word;
            }
            Console.WriteLine(string.Join("\n", words));

        }

    }
}








