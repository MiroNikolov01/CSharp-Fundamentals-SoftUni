namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Calculation(i);
            }
        }
        static void Calculation(int digit)
        {
            int sum = 0;
            int copyNum = digit;

            for (int j = 0; j < copyNum; j++)
            {
                int Lastdigit = digit % 10;
                digit /= 10;
                sum += Lastdigit;
                if (digit == 0)
                {
                    break;
                }
            }

            bool isOdd = ContainsAlteastOneOdd(copyNum);
            if (sum % 8 == 0 && isOdd)
            {
                Console.WriteLine(copyNum);
            }
        }
        static bool ContainsAlteastOneOdd(int number)
        {
            bool isOdd = false;
            for (int i = 0; i < number; i++)
            {
                int checkNumber = number % 10;
                number /= 10;
                if (checkNumber % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
                if (number == 0)
                {
                    break;
                }

            }
            return isOdd;
        }
    }
}

