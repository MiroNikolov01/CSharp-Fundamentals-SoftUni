namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = Console.ReadLine()
                .Split()
                .Where(f => f.Length % 2 == 0)
                .ToArray();
            Console.WriteLine(string.Join("\n", fruits));
        }


    }
}
