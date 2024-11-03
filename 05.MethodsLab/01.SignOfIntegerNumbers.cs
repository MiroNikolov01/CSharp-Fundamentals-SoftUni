namespace MethodsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            SignOfIntegerNumbers(input);
        }
        static void SignOfIntegerNumbers(int num)
        {
            string sign = String.Empty;
            if (num > 0)
                sign = "positive";
            else if (num < 0)
                sign = "negative";
            else
                sign = "zero";
            Console.WriteLine($"The number {num} is {sign}.");
        }
    }
}
