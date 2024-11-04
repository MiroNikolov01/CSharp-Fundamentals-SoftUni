namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            Console.WriteLine(VowelsCountChecker(input));
        }
        static int VowelsCountChecker(string input)
        {
            int count = 0;
            char[] vowels = {
                'a',
                'o',
                'u',
                'e',
                'i'
            };
            foreach (char c in vowels)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i]
                        .ToString()
                        .Contains(c))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
