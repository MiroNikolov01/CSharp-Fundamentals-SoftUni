namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.StartsWith("-"))
            {
                input = input.Substring(1);
            }
            string numEven = "";
            string numOdd = "";
            int sumEven = 0;
            int sumOdd = 0;
            int[] digit = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                digit[i] = int.Parse(input[i].ToString());
                if (digit[i] % 2 == 0)
                {
                    numEven += digit[i].ToString() + " ";
                    sumEven += digit[i];
                }
                else
                {
                    numOdd += digit[i].ToString() + " ";
                    sumOdd += digit[i];
                }

            }
            int result = sumEven * sumOdd;
            Console.WriteLine(result);


        }
    }
}
