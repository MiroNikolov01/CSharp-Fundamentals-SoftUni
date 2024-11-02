namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            switch (inputType)
            {
                case "string":
                    Console.WriteLine(GetMaxString());
                    break;
                case "char":
                    Console.WriteLine(GetMaxChar());
                    break;
                case "int":
                    Console.WriteLine(GetMaxInt());
                    break;

            }
        }
        static string GetMaxString()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            if (firstString.CompareTo(secondString) > 0)
            {
                return firstString;
            }
            return secondString;
        }
        static char GetMaxChar()
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());
            if ((int)firstCh > (int)secondCh)
            {
                return firstCh;
            }
            return secondCh;

        }
        static int GetMaxInt()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            return secondNum;
        }
    }
}

