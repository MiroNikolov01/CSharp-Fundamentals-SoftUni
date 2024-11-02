namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine(SubtractingSum(firstNum, secondNum, thirdNum));
        }
        static int SumOfTwoIntegers(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        static int SubtractingSum(int numOne, int numTwo, int numThre)
        {
            return SumOfTwoIntegers(numOne, numTwo) - numThre;
        }
    }
}

