namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumberChecker(numberOne, numberTwo, numberThree));
        }
        static int SmallestNumberChecker(int n1, int n2, int n3)
        {
            int result = Math.Min(n1, Math.Min(n2, n3));
            return result;
        }

    }
}
