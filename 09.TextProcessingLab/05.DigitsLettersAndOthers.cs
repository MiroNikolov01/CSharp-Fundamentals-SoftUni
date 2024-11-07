namespace _05.DigitsLettersAndOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char[] charElements = inputString.ToCharArray();
            string numbers = "";
            string letters = "";
            string symbols = "";
            for (int i = 0; i < charElements.Length; i++)
            {
                if (char.IsDigit(charElements[i]))
                {
                    numbers += charElements[i];
                }
                else if (char.IsLetter(charElements[i]))
                {
                    letters += charElements[i];
                }
                else
                {
                    symbols += charElements[i];
                }
            }
            Console.WriteLine($"{numbers}\n{letters}\n{symbols}");

        }
    }
}
