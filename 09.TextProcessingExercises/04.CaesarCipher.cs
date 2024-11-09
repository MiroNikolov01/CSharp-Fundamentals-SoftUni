namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] toChar = input.ToCharArray();

            string output = string.Empty;
            for (int i = 0; i < toChar.Length; i++)
            {
                char currentChar = (char)(toChar[i] + 3);
                output += currentChar;
            }
            Console.WriteLine(output);
        }
    }
}
