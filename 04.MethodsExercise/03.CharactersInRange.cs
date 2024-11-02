namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputOne = char.Parse(Console.ReadLine());
            char inputTwo = char.Parse(Console.ReadLine());
            PrintingSymbolsInBetween(inputOne, inputTwo);

        }
        static void PrintingSymbolsInBetween(char charOne, char charTwo)
        {
            if (charOne > charTwo)
            {
                char temp = charOne;
                charOne = charTwo;
                charTwo = temp;
            }
            for (char i = (char)(charOne + 1); i < charTwo; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
