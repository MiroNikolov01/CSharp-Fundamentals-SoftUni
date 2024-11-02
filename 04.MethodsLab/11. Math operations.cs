namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(OperationProcess(numOne, operation, numTwo));
        }
        static int OperationProcess(int numOne, char operation, int numTwo)
        {
            int result = 0;
            switch (operation)
            {
                case '+':
                    result = numOne + numTwo;
                    break;
                case '/':
                    result = numOne / numTwo;
                    break;
                case '*':
                    result = numOne * numTwo;
                    break;
                case '-':
                    result = numOne - numTwo;
                    break;
            }
            return result;
        }
    }
}
