namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            long n1 = long.Parse(Console.ReadLine());
            long n2 = long.Parse(Console.ReadLine());

            // Check for negative inputs
            if (n1 < 0 || n2 < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }
            Console.WriteLine($"{Factorial(n1) / Factorial(n2):f2}");
        }

        // Factorial method
        static double Factorial(long n)
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}



