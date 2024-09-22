namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= count; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += (int)input;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
