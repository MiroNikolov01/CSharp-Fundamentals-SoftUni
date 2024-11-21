namespace _02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbolOne = char.Parse(Console.ReadLine());
            char symbolTwo = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] > symbolOne && input[j] < symbolTwo)
                {
                    sum += (int)input[j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
