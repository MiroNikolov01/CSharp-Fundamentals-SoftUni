namespace _01.CountCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charElements = new();
            string inputString = Console.ReadLine();
            foreach (char c in inputString)
            {
                if (c != ' ')
                {
                    if (charElements.ContainsKey(c))
                    {
                        charElements[c]++;
                    }
                    else
                    {
                        charElements[c] = 1;

                    }
                }

            }
            foreach (var entry in charElements)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
